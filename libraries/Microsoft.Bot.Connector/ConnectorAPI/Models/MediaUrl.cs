// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Bot.Connector
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Media URL
    /// </summary>
    public partial class MediaUrl
    {
        /// <summary>
        /// Initializes a new instance of the MediaUrl class.
        /// </summary>
        public MediaUrl()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MediaUrl class.
        /// </summary>
        /// <param name="url">Url for the media</param>
        /// <param name="profile">Optional profile hint to the client to
        /// differentiate multiple MediaUrl objects from each other</param>
        public MediaUrl(string url, string profile = default(string))
        {
            Url = url;
            Profile = profile;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets url for the media
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }

        /// <summary>
        /// Gets or sets optional profile hint to the client to differentiate
        /// multiple MediaUrl objects from each other
        /// </summary>
        [JsonProperty(PropertyName = "profile")]
        public string Profile { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Url == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Url");
            }
        }
    }
}
