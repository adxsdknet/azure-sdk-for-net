// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.AppService.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.AppService;
    using Microsoft.Azure.Management.AppService.Fluent;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Domain ownership Identifier.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class DomainOwnershipIdentifierInner : Microsoft.Azure.Management.ResourceManager.Fluent.Resource
    {
        /// <summary>
        /// Initializes a new instance of the DomainOwnershipIdentifierInner
        /// class.
        /// </summary>
        public DomainOwnershipIdentifierInner()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DomainOwnershipIdentifierInner
        /// class.
        /// </summary>
        /// <param name="ownershipId">Ownership Id.</param>
        public DomainOwnershipIdentifierInner(string location = default(string), string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string ownershipId = default(string))
            : base(location, id, name, type, tags)
        {
            OwnershipId = ownershipId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets ownership Id.
        /// </summary>
        [JsonProperty(PropertyName = "properties.ownershipId")]
        public string OwnershipId { get; set; }

    }
}
