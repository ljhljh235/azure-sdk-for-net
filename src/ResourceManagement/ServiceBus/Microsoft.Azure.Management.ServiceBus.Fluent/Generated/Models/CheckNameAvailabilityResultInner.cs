// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Fluent.ServiceBus.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Fluent;
    using Microsoft.Azure.Management.Fluent.ServiceBus;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Description of a Check Name availability request properties.
    /// </summary>
    public partial class CheckNameAvailabilityResultInner
    {
        /// <summary>
        /// Initializes a new instance of the CheckNameAvailabilityResultInner
        /// class.
        /// </summary>
        public CheckNameAvailabilityResultInner()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CheckNameAvailabilityResultInner
        /// class.
        /// </summary>
        /// <param name="nameAvailable">Value indicating namespace is
        /// availability, true if the namespace is available; otherwise,
        /// false.</param>
        /// <param name="reason">The reason for unavailability of a namespace.
        /// Possible values include: 'None', 'InvalidName',
        /// 'SubscriptionIsDisabled', 'NameInUse', 'NameInLockdown',
        /// 'TooManyNamespaceInCurrentSubscription'</param>
        /// <param name="message">The detailed info regarding the reason
        /// associated with the namespace.</param>
        public CheckNameAvailabilityResultInner(bool? nameAvailable = default(bool?), string reason = default(string), string message = default(string))
        {
            NameAvailable = nameAvailable;
            Reason = reason;
            Message = message;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets value indicating namespace is availability, true if
        /// the namespace is available; otherwise, false.
        /// </summary>
        [JsonProperty(PropertyName = "nameAvailable")]
        public bool? NameAvailable { get; set; }

        /// <summary>
        /// Gets or sets the reason for unavailability of a namespace. Possible
        /// values include: 'None', 'InvalidName', 'SubscriptionIsDisabled',
        /// 'NameInUse', 'NameInLockdown',
        /// 'TooManyNamespaceInCurrentSubscription'
        /// </summary>
        [JsonProperty(PropertyName = "reason")]
        public string Reason { get; set; }

        /// <summary>
        /// Gets the detailed info regarding the reason associated with the
        /// namespace.
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; private set; }

    }
}