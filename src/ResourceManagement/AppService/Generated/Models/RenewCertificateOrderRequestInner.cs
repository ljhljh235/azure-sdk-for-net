// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
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
    /// Class representing certificate renew request.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class RenewCertificateOrderRequestInner : Rest.Azure.Resource
    {
        /// <summary>
        /// Initializes a new instance of the RenewCertificateOrderRequestInner
        /// class.
        /// </summary>
        public RenewCertificateOrderRequestInner()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RenewCertificateOrderRequestInner
        /// class.
        /// </summary>
        /// <param name="keySize">Certificate Key Size.</param>
        /// <param name="csr">Csr to be used for re-key operation.</param>
        /// <param name="isPrivateKeyExternal">Should we change the ASC type
        /// (from managed private key to external private key and vice
        /// versa).</param>
        public RenewCertificateOrderRequestInner(string location = default(string), string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), int? keySize = default(int?), string csr = default(string), bool? isPrivateKeyExternal = default(bool?))
            : base(location, id, name, type, tags)
        {
            KeySize = keySize;
            Csr = csr;
            IsPrivateKeyExternal = isPrivateKeyExternal;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets certificate Key Size.
        /// </summary>
        [JsonProperty(PropertyName = "properties.keySize")]
        public int? KeySize { get; set; }

        /// <summary>
        /// Gets or sets csr to be used for re-key operation.
        /// </summary>
        [JsonProperty(PropertyName = "properties.csr")]
        public string Csr { get; set; }

        /// <summary>
        /// Gets or sets should we change the ASC type (from managed private
        /// key to external private key and vice versa).
        /// </summary>
        [JsonProperty(PropertyName = "properties.isPrivateKeyExternal")]
        public bool? IsPrivateKeyExternal { get; set; }

    }
}
