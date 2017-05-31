// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Graph.RBAC.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Graph;
    using Microsoft.Azure.Management.Graph.RBAC;
    using Microsoft.Azure.Management.Graph.RBAC.Fluent;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Active Directory user information.
    /// </summary>
    public partial class UserInner
    {
        /// <summary>
        /// Initializes a new instance of the UserInner class.
        /// </summary>
        public UserInner()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the UserInner class.
        /// </summary>
        /// <param name="objectId">The object ID.</param>
        /// <param name="objectType">The object type.</param>
        /// <param name="userPrincipalName">The principal name of the
        /// user.</param>
        /// <param name="displayName">The display name of the user.</param>
        /// <param name="signInName">The sign-in name of the user.</param>
        /// <param name="mail">The primary email address of the user.</param>
        /// <param name="mailNickname">The mail alias for the user.</param>
        /// <param name="usageLocation">A two letter country code (ISO standard
        /// 3166). Required for users that will be assigned licenses due to
        /// legal requirement to check for availability of services in
        /// countries. Examples include: "US", "JP", and "GB".</param>
        public UserInner(string objectId = default(string), string objectType = default(string), string userPrincipalName = default(string), string displayName = default(string), string signInName = default(string), string mail = default(string), string mailNickname = default(string), string usageLocation = default(string))
        {
            ObjectId = objectId;
            ObjectType = objectType;
            UserPrincipalName = userPrincipalName;
            DisplayName = displayName;
            SignInName = signInName;
            Mail = mail;
            MailNickname = mailNickname;
            UsageLocation = usageLocation;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the object ID.
        /// </summary>
        [JsonProperty(PropertyName = "objectId")]
        public string ObjectId { get; set; }

        /// <summary>
        /// Gets or sets the object type.
        /// </summary>
        [JsonProperty(PropertyName = "objectType")]
        public string ObjectType { get; set; }

        /// <summary>
        /// Gets or sets the principal name of the user.
        /// </summary>
        [JsonProperty(PropertyName = "userPrincipalName")]
        public string UserPrincipalName { get; set; }

        /// <summary>
        /// Gets or sets the display name of the user.
        /// </summary>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets the sign-in name of the user.
        /// </summary>
        [JsonProperty(PropertyName = "signInName")]
        public string SignInName { get; set; }

        /// <summary>
        /// Gets or sets the primary email address of the user.
        /// </summary>
        [JsonProperty(PropertyName = "mail")]
        public string Mail { get; set; }

        /// <summary>
        /// Gets or sets the mail alias for the user.
        /// </summary>
        [JsonProperty(PropertyName = "mailNickname")]
        public string MailNickname { get; set; }

        /// <summary>
        /// Gets or sets a two letter country code (ISO standard 3166).
        /// Required for users that will be assigned licenses due to legal
        /// requirement to check for availability of services in countries.
        /// Examples include: "US", "JP", and "GB".
        /// </summary>
        [JsonProperty(PropertyName = "usageLocation")]
        public string UsageLocation { get; set; }

    }
}
