// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Monitor.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Specifies the metric alert criteria for a single resource that has
    /// multiple metric criteria.
    /// </summary>
    [Newtonsoft.Json.JsonObject("Microsoft.Azure.Monitor.SingleResourceMultipleMetricCriteria")]
    public partial class MetricAlertSingleResourceMultipleMetricCriteria : MetricAlertCriteria
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MetricAlertSingleResourceMultipleMetricCriteria class.
        /// </summary>
        public MetricAlertSingleResourceMultipleMetricCriteria()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MetricAlertSingleResourceMultipleMetricCriteria class.
        /// </summary>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="allOf">The list of metric criteria for this 'all of'
        /// operation. </param>
        public MetricAlertSingleResourceMultipleMetricCriteria(IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), IList<StaticMetricCriteria> allOf = default(IList<StaticMetricCriteria>))
            : base(additionalProperties)
        {
            AllOf = allOf;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the list of metric criteria for this 'all of'
        /// operation.
        /// </summary>
        [JsonProperty(PropertyName = "allOf")]
        public IList<StaticMetricCriteria> AllOf { get; set; }

    }
}
