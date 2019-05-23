// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ContainerRegistry.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The properties for updating base image dependency trigger.
    /// </summary>
    public partial class BaseImageTriggerUpdateParameters
    {
        /// <summary>
        /// Initializes a new instance of the BaseImageTriggerUpdateParameters
        /// class.
        /// </summary>
        public BaseImageTriggerUpdateParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BaseImageTriggerUpdateParameters
        /// class.
        /// </summary>
        /// <param name="name">The name of the trigger.</param>
        /// <param name="baseImageTriggerType">The type of the auto trigger for
        /// base image dependency updates. Possible values include: 'All',
        /// 'Runtime'</param>
        /// <param name="updateTriggerEndpoint">The endpoint URL for receiving
        /// update triggers.</param>
        /// <param name="includeTriggerMetadata">Include Trigger metadata on
        /// Base image update triggers.</param>
        /// <param name="status">The current status of trigger. Possible values
        /// include: 'Disabled', 'Enabled'</param>
        public BaseImageTriggerUpdateParameters(string name, string baseImageTriggerType = default(string), string updateTriggerEndpoint = default(string), bool? includeTriggerMetadata = default(bool?), string status = default(string))
        {
            BaseImageTriggerType = baseImageTriggerType;
            UpdateTriggerEndpoint = updateTriggerEndpoint;
            IncludeTriggerMetadata = includeTriggerMetadata;
            Status = status;
            Name = name;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the type of the auto trigger for base image dependency
        /// updates. Possible values include: 'All', 'Runtime'
        /// </summary>
        [JsonProperty(PropertyName = "baseImageTriggerType")]
        public string BaseImageTriggerType { get; set; }

        /// <summary>
        /// Gets or sets the endpoint URL for receiving update triggers.
        /// </summary>
        [JsonProperty(PropertyName = "updateTriggerEndpoint")]
        public string UpdateTriggerEndpoint { get; set; }

        /// <summary>
        /// Gets or sets include Trigger metadata on Base image update
        /// triggers.
        /// </summary>
        [JsonProperty(PropertyName = "includeTriggerMetadata")]
        public bool? IncludeTriggerMetadata { get; set; }

        /// <summary>
        /// Gets or sets the current status of trigger. Possible values
        /// include: 'Disabled', 'Enabled'
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets the name of the trigger.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
        }
    }
}
