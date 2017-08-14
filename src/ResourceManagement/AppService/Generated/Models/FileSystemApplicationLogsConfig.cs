// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.AppService.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.AppService;
    using Microsoft.Azure.Management.AppService.Fluent;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Application logs to file system configuration.
    /// </summary>
    public partial class FileSystemApplicationLogsConfig
    {
        /// <summary>
        /// Initializes a new instance of the FileSystemApplicationLogsConfig
        /// class.
        /// </summary>
        public FileSystemApplicationLogsConfig()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the FileSystemApplicationLogsConfig
        /// class.
        /// </summary>
        /// <param name="level">Log level. Possible values include: 'Off',
        /// 'Verbose', 'Information', 'Warning', 'Error'</param>
        public FileSystemApplicationLogsConfig(LogLevel? level = default(LogLevel?))
        {
            Level = level;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets log level. Possible values include: 'Off', 'Verbose',
        /// 'Information', 'Warning', 'Error'
        /// </summary>
        [JsonProperty(PropertyName = "level")]
        public LogLevel? Level { get; set; }

    }
}
