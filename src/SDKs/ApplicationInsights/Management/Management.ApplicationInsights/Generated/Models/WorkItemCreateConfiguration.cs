// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ApplicationInsights.Management.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Work item configuration creation payload
    /// </summary>
    public partial class WorkItemCreateConfiguration
    {
        /// <summary>
        /// Initializes a new instance of the WorkItemCreateConfiguration
        /// class.
        /// </summary>
        public WorkItemCreateConfiguration()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the WorkItemCreateConfiguration
        /// class.
        /// </summary>
        /// <param name="connectorId">Unique connector id</param>
        /// <param name="connectorDataConfiguration">Serialized JSON object for
        /// detailed properties</param>
        /// <param name="validateOnly">True or false string indicating validate
        /// only</param>
        /// <param name="workItemProperties">Custom work item
        /// properties</param>
        public WorkItemCreateConfiguration(string connectorId = default(string), string connectorDataConfiguration = default(string), string validateOnly = default(string), IDictionary<string, string> workItemProperties = default(IDictionary<string, string>))
        {
            ConnectorId = connectorId;
            ConnectorDataConfiguration = connectorDataConfiguration;
            ValidateOnly = validateOnly;
            WorkItemProperties = workItemProperties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets unique connector id
        /// </summary>
        [JsonProperty(PropertyName = "ConnectorId")]
        public string ConnectorId { get; set; }

        /// <summary>
        /// Gets or sets serialized JSON object for detailed properties
        /// </summary>
        [JsonProperty(PropertyName = "ConnectorDataConfiguration")]
        public string ConnectorDataConfiguration { get; set; }

        /// <summary>
        /// Gets or sets true or false string indicating validate only
        /// </summary>
        [JsonProperty(PropertyName = "ValidateOnly")]
        public string ValidateOnly { get; set; }

        /// <summary>
        /// Gets or sets custom work item properties
        /// </summary>
        [JsonProperty(PropertyName = "WorkItemProperties")]
        public IDictionary<string, string> WorkItemProperties { get; set; }

    }
}
