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
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Description of a SKU for a scalable resource.
    /// </summary>
    public partial class SkuDescription
    {
        /// <summary>
        /// Initializes a new instance of the SkuDescription class.
        /// </summary>
        public SkuDescription()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SkuDescription class.
        /// </summary>
        /// <param name="name">Name of the resource SKU.</param>
        /// <param name="tier">Service tier of the resource SKU.</param>
        /// <param name="size">Size specifier of the resource SKU.</param>
        /// <param name="family">Family code of the resource SKU.</param>
        /// <param name="capacity">Current number of instances assigned to the
        /// resource.</param>
        /// <param name="skuCapacity">Min, max, and default scale values of the
        /// SKU.</param>
        /// <param name="locations">Locations of the SKU.</param>
        /// <param name="capabilities">Capabilities of the SKU, e.g., is
        /// traffic manager enabled?</param>
        public SkuDescription(string name = default(string), string tier = default(string), string size = default(string), string family = default(string), int? capacity = default(int?), SkuCapacity skuCapacity = default(SkuCapacity), IList<string> locations = default(IList<string>), IList<CapabilityInner> capabilities = default(IList<CapabilityInner>))
        {
            Name = name;
            Tier = tier;
            Size = size;
            Family = family;
            Capacity = capacity;
            SkuCapacity = skuCapacity;
            Locations = locations;
            Capabilities = capabilities;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets name of the resource SKU.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets service tier of the resource SKU.
        /// </summary>
        [JsonProperty(PropertyName = "tier")]
        public string Tier { get; set; }

        /// <summary>
        /// Gets or sets size specifier of the resource SKU.
        /// </summary>
        [JsonProperty(PropertyName = "size")]
        public string Size { get; set; }

        /// <summary>
        /// Gets or sets family code of the resource SKU.
        /// </summary>
        [JsonProperty(PropertyName = "family")]
        public string Family { get; set; }

        /// <summary>
        /// Gets or sets current number of instances assigned to the resource.
        /// </summary>
        [JsonProperty(PropertyName = "capacity")]
        public int? Capacity { get; set; }

        /// <summary>
        /// Gets or sets min, max, and default scale values of the SKU.
        /// </summary>
        [JsonProperty(PropertyName = "skuCapacity")]
        public SkuCapacity SkuCapacity { get; set; }

        /// <summary>
        /// Gets or sets locations of the SKU.
        /// </summary>
        [JsonProperty(PropertyName = "locations")]
        public IList<string> Locations { get; set; }

        /// <summary>
        /// Gets or sets capabilities of the SKU, e.g., is traffic manager
        /// enabled?
        /// </summary>
        [JsonProperty(PropertyName = "capabilities")]
        public IList<CapabilityInner> Capabilities { get; set; }

    }
}
