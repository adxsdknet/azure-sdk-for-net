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
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// An SMS receiver.
    /// </summary>
    public partial class SmsReceiver
    {
        /// <summary>
        /// Initializes a new instance of the SmsReceiver class.
        /// </summary>
        public SmsReceiver()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SmsReceiver class.
        /// </summary>
        /// <param name="name">The name of the SMS receiver. Names must be
        /// unique across all receivers within an action group.</param>
        /// <param name="countryCode">The country code of the SMS
        /// receiver.</param>
        /// <param name="phoneNumber">The phone number of the SMS
        /// receiver.</param>
        /// <param name="status">The status of the receiver. Possible values
        /// include: 'NotSpecified', 'Enabled', 'Disabled'</param>
        public SmsReceiver(string name, string countryCode, string phoneNumber, ReceiverStatus? status = default(ReceiverStatus?))
        {
            Name = name;
            CountryCode = countryCode;
            PhoneNumber = phoneNumber;
            Status = status;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the SMS receiver. Names must be unique
        /// across all receivers within an action group.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the country code of the SMS receiver.
        /// </summary>
        [JsonProperty(PropertyName = "countryCode")]
        public string CountryCode { get; set; }

        /// <summary>
        /// Gets or sets the phone number of the SMS receiver.
        /// </summary>
        [JsonProperty(PropertyName = "phoneNumber")]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Gets the status of the receiver. Possible values include:
        /// 'NotSpecified', 'Enabled', 'Disabled'
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public ReceiverStatus? Status { get; private set; }

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
            if (CountryCode == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "CountryCode");
            }
            if (PhoneNumber == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "PhoneNumber");
            }
        }
    }
}
