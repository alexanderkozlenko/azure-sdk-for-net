// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> Properties for the command that finishes a migration in whole or in part. </summary>
    public partial class DataMigrationMongoDBFinishCommand : DataMigrationCommandProperties
    {
        /// <summary> Initializes a new instance of <see cref="DataMigrationMongoDBFinishCommand"/>. </summary>
        public DataMigrationMongoDBFinishCommand()
        {
            CommandType = DataMigrationCommandType.Finish;
        }

        /// <summary> Initializes a new instance of <see cref="DataMigrationMongoDBFinishCommand"/>. </summary>
        /// <param name="commandType"> Command type. </param>
        /// <param name="errors"> Array of errors. This is ignored if submitted. </param>
        /// <param name="state"> The state of the command. This is ignored if submitted. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="input"> Command input. </param>
        internal DataMigrationMongoDBFinishCommand(DataMigrationCommandType commandType, IReadOnlyList<DataMigrationODataError> errors, DataMigrationCommandState? state, IDictionary<string, BinaryData> serializedAdditionalRawData, DataMigrationMongoDBFinishCommandInput input) : base(commandType, errors, state, serializedAdditionalRawData)
        {
            Input = input;
            CommandType = commandType;
        }

        /// <summary> Command input. </summary>
        public DataMigrationMongoDBFinishCommandInput Input { get; set; }
    }
}
