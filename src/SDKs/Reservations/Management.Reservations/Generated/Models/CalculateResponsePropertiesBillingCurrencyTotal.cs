// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Reservations.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class CalculateResponsePropertiesBillingCurrencyTotal
    {
        /// <summary>
        /// Initializes a new instance of the
        /// CalculateResponsePropertiesBillingCurrencyTotal class.
        /// </summary>
        public CalculateResponsePropertiesBillingCurrencyTotal()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// CalculateResponsePropertiesBillingCurrencyTotal class.
        /// </summary>
        public CalculateResponsePropertiesBillingCurrencyTotal(string currencyCode = default(string), double? estimatedTotal = default(double?))
        {
            CurrencyCode = currencyCode;
            EstimatedTotal = estimatedTotal;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "currencyCode")]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "estimatedTotal")]
        public double? EstimatedTotal { get; set; }

    }
}