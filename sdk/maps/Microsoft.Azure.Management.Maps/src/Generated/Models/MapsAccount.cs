// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Maps.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// An Azure resource which represents access to a suite of Maps REST APIs.
    /// </summary>
    public partial class MapsAccount : Resource
    {
        /// <summary>
        /// Initializes a new instance of the MapsAccount class.
        /// </summary>
        public MapsAccount()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MapsAccount class.
        /// </summary>
        /// <param name="id">The fully qualified Maps Account resource
        /// identifier.</param>
        /// <param name="name">The name of the Maps Account, which is unique
        /// within a Resource Group.</param>
        /// <param name="type">Azure resource type.</param>
        /// <param name="location">The location of the resource.</param>
        /// <param name="tags">Gets a list of key value pairs that describe the
        /// resource. These tags can be used in viewing and grouping this
        /// resource (across resource groups). A maximum of 15 tags can be
        /// provided for a resource. Each tag must have a key no greater than
        /// 128 characters and value no greater than 256 characters.</param>
        /// <param name="sku">The SKU of this account.</param>
        /// <param name="properties">The map account properties.</param>
        public MapsAccount(string id = default(string), string name = default(string), string type = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), Sku sku = default(Sku), MapsAccountProperties properties = default(MapsAccountProperties))
            : base(id, name, type)
        {
            Location = location;
            Tags = tags;
            Sku = sku;
            Properties = properties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the location of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; private set; }

        /// <summary>
        /// Gets a list of key value pairs that describe the resource. These
        /// tags can be used in viewing and grouping this resource (across
        /// resource groups). A maximum of 15 tags can be provided for a
        /// resource. Each tag must have a key no greater than 128 characters
        /// and value no greater than 256 characters.
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; private set; }

        /// <summary>
        /// Gets the SKU of this account.
        /// </summary>
        [JsonProperty(PropertyName = "sku")]
        public Sku Sku { get; private set; }

        /// <summary>
        /// Gets the map account properties.
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public MapsAccountProperties Properties { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Sku != null)
            {
                Sku.Validate();
            }
        }
    }
}