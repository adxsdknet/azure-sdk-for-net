// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// SSIS package exection log location
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class SSISLogLocation
    {
        /// <summary>
        /// Initializes a new instance of the SSISLogLocation class.
        /// </summary>
        public SSISLogLocation()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SSISLogLocation class.
        /// </summary>
        /// <param name="logPath">The SSIS package execution log path. Type:
        /// string (or Expression with resultType string).</param>
        /// <param name="accessCredential">The package execution log access
        /// credential.</param>
        public SSISLogLocation(object logPath, SSISAccessCredential accessCredential = default(SSISAccessCredential))
        {
            LogPath = logPath;
            AccessCredential = accessCredential;
            CustomInit();
        }
        /// <summary>
        /// Static constructor for SSISLogLocation class.
        /// </summary>
        static SSISLogLocation()
        {
            Type = "File";
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the SSIS package execution log path. Type: string (or
        /// Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "logPath")]
        public object LogPath { get; set; }

        /// <summary>
        /// Gets or sets the package execution log access credential.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.accessCredential")]
        public SSISAccessCredential AccessCredential { get; set; }

        /// <summary>
        /// The type of SSIS log location.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public static string Type { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (LogPath == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "LogPath");
            }
            if (AccessCredential != null)
            {
                AccessCredential.Validate();
            }
        }
    }
}
