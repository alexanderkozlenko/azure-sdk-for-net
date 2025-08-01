﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using Azure.Core;

namespace Azure.Identity
{
    internal class DefaultAzureCredentialFactory
    {
        private static readonly TokenCredential[] s_defaultCredentialChain = new DefaultAzureCredentialFactory(new DefaultAzureCredentialOptions()).CreateCredentialChain();
        private bool _useDefaultCredentialChain;

        public DefaultAzureCredentialFactory(DefaultAzureCredentialOptions options)
            : this(options, CredentialPipeline.GetInstance(options))
        { }

        protected DefaultAzureCredentialFactory(DefaultAzureCredentialOptions options, CredentialPipeline pipeline)
        {
            Pipeline = pipeline;
            _useDefaultCredentialChain = options == null;
            Options = options?.Clone<DefaultAzureCredentialOptions>() ?? new DefaultAzureCredentialOptions();
        }

        public DefaultAzureCredentialOptions Options { get; }
        public CredentialPipeline Pipeline { get; }

        public TokenCredential[] CreateCredentialChain()
        {
            string credentialSelection = EnvironmentVariables.CredentialSelection?.Trim().ToLower();
            bool _useDevCredentials = Constants.DevCredentials.Equals(credentialSelection, StringComparison.OrdinalIgnoreCase);
            bool _useProdCredentials = Constants.ProdCredentials.Equals(credentialSelection, StringComparison.OrdinalIgnoreCase);

            if (_useDefaultCredentialChain)
            {
                if (_useDevCredentials)
                {
                    return
                    [
                        CreateVisualStudioCredential(),
                        CreateVisualStudioCodeCredential(),
                        CreateAzureCliCredential(),
                        CreateAzurePowerShellCredential(),
                        CreateAzureDeveloperCliCredential()
                    ];
                }
                else if (_useProdCredentials)
                {
                    return
                    [
                        CreateEnvironmentCredential(),
                        CreateWorkloadIdentityCredential(),
                        CreateManagedIdentityCredential()
                    ];
                }
                else if (credentialSelection != null)
                {
                    string validCredentials = $"'{Constants.DevCredentials}', '{Constants.ProdCredentials}', '{Constants.VisualStudioCredential}', '{Constants.VisualStudioCodeCredential}', '{Constants.AzureCliCredential}', '{Constants.AzurePowerShellCredential}', '{Constants.AzureDeveloperCliCredential}', '{Constants.EnvironmentCredential}', '{Constants.WorkloadIdentityCredential}', '{Constants.ManagedIdentityCredential}', '{Constants.InteractiveBrowserCredential}', '{Constants.BrokerAuthenticationCredential}'";
                    return credentialSelection switch
                    {
                        Constants.VisualStudioCredential => [CreateVisualStudioCredential()],
                        Constants.VisualStudioCodeCredential => [CreateVisualStudioCodeCredential()],
                        Constants.AzureCliCredential => [CreateAzureCliCredential()],
                        Constants.AzurePowerShellCredential => [CreateAzurePowerShellCredential()],
                        Constants.AzureDeveloperCliCredential => [CreateAzureDeveloperCliCredential()],
                        Constants.EnvironmentCredential => [CreateEnvironmentCredential()],
                        Constants.WorkloadIdentityCredential => [CreateWorkloadIdentityCredential()],
                        Constants.ManagedIdentityCredential => [CreateManagedIdentityCredential()],
                        Constants.InteractiveBrowserCredential => [CreateInteractiveBrowserCredential()],
                        Constants.BrokerAuthenticationCredential =>
                            TryCreateDevelopmentBrokerOptions(out InteractiveBrowserCredentialOptions brokerOptions)
                                ? [CreateBrokerAuthenticationCredential(brokerOptions)]
                                : throw new CredentialUnavailableException("BrokerAuthenticationCredential is not available without a reference to Azure.Identity.Broker."),
                        _ => throw new InvalidOperationException($"Invalid value for environment variable AZURE_TOKEN_CREDENTIALS: {credentialSelection}. Valid values are {validCredentials}. See https://aka.ms/azsdk/net/identity/defaultazurecredential/troubleshoot for more information.")
                    };
                }
                return s_defaultCredentialChain;
            }

            List<TokenCredential> chain = new(10);

            if (!_useDevCredentials)
            {
                if (!Options.ExcludeEnvironmentCredential)
                {
                    chain.Add(CreateEnvironmentCredential());
                }

                if (!Options.ExcludeWorkloadIdentityCredential)
                {
                    chain.Add(CreateWorkloadIdentityCredential());
                }

                if (!Options.ExcludeManagedIdentityCredential)
                {
                    chain.Add(CreateManagedIdentityCredential());
                }
            }

            if (!_useProdCredentials)
            {
#pragma warning disable CS0618 // Type of member is obsolete
                if (!Options.ExcludeSharedTokenCacheCredential)
                {
                    chain.Add(CreateSharedTokenCacheCredential());
                }
#pragma warning restore CS0618

                if (!Options.ExcludeVisualStudioCredential)
                {
                    chain.Add(CreateVisualStudioCredential());
                }

                if (!Options.ExcludeVisualStudioCodeCredential)
                {
                    chain.Add(CreateVisualStudioCodeCredential());
                }

                if (!Options.ExcludeAzureCliCredential)
                {
                    chain.Add(CreateAzureCliCredential());
                }

                if (!Options.ExcludeAzurePowerShellCredential)
                {
                    chain.Add(CreateAzurePowerShellCredential());
                }

                if (!Options.ExcludeAzureDeveloperCliCredential)
                {
                    chain.Add(CreateAzureDeveloperCliCredential());
                }

                if (!Options.ExcludeInteractiveBrowserCredential)
                {
                    chain.Add(CreateInteractiveBrowserCredential());
                }
                if (!Options.ExcludeBrokerCredential && TryCreateDevelopmentBrokerOptions(out InteractiveBrowserCredentialOptions brokerOptions))
                {
                    chain.Add(CreateBrokerAuthenticationCredential(brokerOptions));
                }
            }
            if (chain.Count == 0)
            {
                throw new ArgumentException("At least one credential type must be included in the authentication flow.", "options");
            }

            return chain.ToArray();
        }

        public virtual TokenCredential CreateEnvironmentCredential()
        {
            var options = Options.Clone<EnvironmentCredentialOptions>();

            if (!string.IsNullOrEmpty(options.TenantId))
            {
                options.TenantId = Options.TenantId;
            }

            return new EnvironmentCredential(Pipeline, options);
        }

        public virtual TokenCredential CreateWorkloadIdentityCredential()
        {
            var options = Options.Clone<WorkloadIdentityCredentialOptions>();

            options.ClientId = Options.WorkloadIdentityClientId;
            options.TenantId = Options.TenantId;
            options.Pipeline = Pipeline;

            return new WorkloadIdentityCredential(options);
        }

        public virtual TokenCredential CreateManagedIdentityCredential()
        {
            var options = Options.Clone<DefaultAzureCredentialOptions>();
            options.IsChainedCredential = true;

            if (options.ManagedIdentityClientId != null && options.ManagedIdentityResourceId != null)
            {
                throw new ArgumentException(
                    $"{nameof(DefaultAzureCredentialOptions)} cannot specify both {nameof(options.ManagedIdentityResourceId)} and {nameof(options.ManagedIdentityClientId)}.");
            }

            var miOptions = new ManagedIdentityClientOptions
            {
                Pipeline = CredentialPipeline.GetInstance(options, IsManagedIdentityCredential: true),
                Options = options,
                InitialImdsConnectionTimeout = TimeSpan.FromSeconds(1),
                ExcludeTokenExchangeManagedIdentitySource = options.ExcludeWorkloadIdentityCredential,
                IsForceRefreshEnabled = options.IsForceRefreshEnabled,
            };

            if (!string.IsNullOrEmpty(options.ManagedIdentityClientId))
            {
                miOptions.ManagedIdentityId = ManagedIdentityId.FromUserAssignedClientId(options.ManagedIdentityClientId);
            }
            else if (options.ManagedIdentityResourceId != null)
            {
                miOptions.ManagedIdentityId = ManagedIdentityId.FromUserAssignedResourceId(options.ManagedIdentityResourceId);
            }
            else
            {
                miOptions.ManagedIdentityId = ManagedIdentityId.SystemAssigned;
            }

            return new ManagedIdentityCredential(new ManagedIdentityClient(miOptions));
        }

        public virtual TokenCredential CreateSharedTokenCacheCredential()
        {
#pragma warning disable CS0618 // Type or member is obsolete
            var options = Options.Clone<SharedTokenCacheCredentialOptions>();

            options.TenantId = Options.SharedTokenCacheTenantId;

            options.Username = Options.SharedTokenCacheUsername;

            return new SharedTokenCacheCredential(Options.SharedTokenCacheTenantId, Options.SharedTokenCacheUsername, options, Pipeline);
#pragma warning restore CS0618
        }

        public virtual TokenCredential CreateInteractiveBrowserCredential()
        {
            var options = Options.Clone<InteractiveBrowserCredentialOptions>();

            options.TokenCachePersistenceOptions = new TokenCachePersistenceOptions();

            options.TenantId = Options.InteractiveBrowserTenantId;

            return new InteractiveBrowserCredential(
                Options.InteractiveBrowserTenantId,
                Options.InteractiveBrowserCredentialClientId ?? Constants.DeveloperSignOnClientId,
                options,
                Pipeline);
        }

        public TokenCredential CreateBrokerAuthenticationCredential(InteractiveBrowserCredentialOptions brokerOptions)
        {
            var options = Options.Clone<DevelopmentBrokerOptions>();
            ((IMsalSettablePublicClientInitializerOptions)options).BeforeBuildClient = ((IMsalSettablePublicClientInitializerOptions)brokerOptions).BeforeBuildClient;
            options.RedirectUri = brokerOptions.RedirectUri;

            options.TokenCachePersistenceOptions = new TokenCachePersistenceOptions();

            options.TenantId = Options.InteractiveBrowserTenantId;
            options.IsChainedCredential = true;

            return new InteractiveBrowserCredential(
                Options.InteractiveBrowserTenantId,
                Options.InteractiveBrowserCredentialClientId ?? Constants.DeveloperSignOnClientId,
                options,
                Pipeline);
        }

        public virtual TokenCredential CreateAzureDeveloperCliCredential()
        {
            var options = Options.Clone<AzureDeveloperCliCredentialOptions>();
            options.TenantId = Options.TenantId;
            options.ProcessTimeout = Options.CredentialProcessTimeout;
            options.IsChainedCredential = true;

            return new AzureDeveloperCliCredential(Pipeline, default, options);
        }

        public virtual TokenCredential CreateAzureCliCredential()
        {
            var options = Options.Clone<AzureCliCredentialOptions>();
            options.TenantId = Options.TenantId;
            options.ProcessTimeout = Options.CredentialProcessTimeout;
            options.IsChainedCredential = true;

            return new AzureCliCredential(Pipeline, default, options);
        }

        public virtual TokenCredential CreateVisualStudioCredential()
        {
            var options = Options.Clone<VisualStudioCredentialOptions>();
            options.TenantId = Options.VisualStudioTenantId;
            options.ProcessTimeout = Options.CredentialProcessTimeout;
            options.IsChainedCredential = true;

            return new VisualStudioCredential(Options.VisualStudioTenantId, Pipeline, default, default, options);
        }

        public virtual TokenCredential CreateVisualStudioCodeCredential()
        {
            var options = Options.Clone<VisualStudioCodeCredentialOptions>();
            options.TenantId = Options.VisualStudioCodeTenantId;
            options.IsChainedCredential = true;

            return new VisualStudioCodeCredential(options);
        }

        public virtual TokenCredential CreateAzurePowerShellCredential()
        {
            var options = Options.Clone<AzurePowerShellCredentialOptions>();
            options.TenantId = Options.TenantId;
            options.ProcessTimeout = Options.CredentialProcessTimeout;
            options.IsChainedCredential = true;

            return new AzurePowerShellCredential(options, Pipeline, default);
        }

        /// <summary>
        /// Creates a DevelopmentBrokerOptions instance if the Azure.Identity.Broker assembly is loaded.
        /// This is used to enable broker authentication for development purposes.
        /// </summary>
        /// <param name="options"></param>
        internal static bool TryCreateDevelopmentBrokerOptions(out InteractiveBrowserCredentialOptions options)
        {
            options = null;
            try
            {
                // Use Type.GetType and ConstructorInfo because they can be analyzed by the ILLinker and are
                // AOT friendly.

                // Try to get the options type
                Type optionsType = Type.GetType("Azure.Identity.Broker.DevelopmentBrokerOptions, Azure.Identity.Broker", throwOnError: false);
                ConstructorInfo optionsCtor = optionsType?.GetConstructor(Type.EmptyTypes);
                object optionsInstance = optionsCtor?.Invoke(null);
                options = optionsInstance as InteractiveBrowserCredentialOptions;
                options.IsChainedCredential = true;
                // Set default value for UseDefaultBrokerAccount on macOS
                if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                {
                    options.RedirectUri = new(Constants.MacBrokerRedirectUri);
                }

                return options != null;
            }
            catch
            {
                return false;
            }
        }
    }
}
