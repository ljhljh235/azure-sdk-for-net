// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.ResourceManager.Models
{
    using System.Linq;

    /// <summary>
    /// Resource group information.
    /// </summary>
    public partial class ResourceGroupInner
    {
        /// <summary>
        /// Initializes a new instance of the ResourceGroupInner class.
        /// </summary>
        public ResourceGroupInner() { }

        /// <summary>
        /// Initializes a new instance of the ResourceGroupInner class.
        /// </summary>
        /// <param name="location">The location of the resource group. It
        /// cannot be changed after the resource group has been created. Has
        /// to be one of the supported Azure Locations, such as West US, East
        /// US, West Europe, East Asia, etc.</param>
        /// <param name="id">The ID of the resource group.</param>
        /// <param name="name">The Name of the resource group.</param>
        /// <param name="tags">The tags attached to the resource group.</param>
        public ResourceGroupInner(string location, string id = default(string), string name = default(string), ResourceGroupProperties properties = default(ResourceGroupProperties), System.Collections.Generic.IDictionary<string, string> tags = default(System.Collections.Generic.IDictionary<string, string>))
        {
            Id = id;
            Name = name;
            Properties = properties;
            Location = location;
            Tags = tags;
        }

        /// <summary>
        /// Gets the ID of the resource group.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        /// <summary>
        /// Gets or sets the Name of the resource group.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties")]
        public ResourceGroupProperties Properties { get; set; }

        /// <summary>
        /// Gets or sets the location of the resource group. It cannot be
        /// changed after the resource group has been created. Has to be one
        /// of the supported Azure Locations, such as West US, East US, West
        /// Europe, East Asia, etc.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets the tags attached to the resource group.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "tags")]
        public System.Collections.Generic.IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Location == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Location");
            }
        }
    }
}
