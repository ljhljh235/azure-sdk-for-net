// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Network.Models
{
    using System.Linq;

    /// <summary>
    /// Network security rule
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class SecurityRuleInner : Microsoft.Rest.Azure.SubResource
    {
        /// <summary>
        /// Initializes a new instance of the SecurityRuleInner class.
        /// </summary>
        public SecurityRuleInner() { }

        /// <summary>
        /// Initializes a new instance of the SecurityRuleInner class.
        /// </summary>
        /// <param name="protocol">Gets or sets Network protocol this rule
        /// applies to. Can be Tcp, Udp or All(*). Possible values include:
        /// 'Tcp', 'Udp', '*'</param>
        /// <param name="sourceAddressPrefix">Gets or sets source address
        /// prefix. CIDR or source IP range. Asterix '*' can also be used to
        /// match all source IPs. Default tags such as 'VirtualNetwork',
        /// 'AzureLoadBalancer' and 'Internet' can also be used. If this is
        /// an ingress rule, specifies where network traffic originates from.
        /// </param>
        /// <param name="destinationAddressPrefix">Gets or sets destination
        /// address prefix. CIDR or source IP range. Asterix '*' can also be
        /// used to match all source IPs. Default tags such as
        /// 'VirtualNetwork', 'AzureLoadBalancer' and 'Internet' can also be
        /// used. </param>
        /// <param name="access">Gets or sets network traffic is allowed or
        /// denied. Possible values are 'Allow' and 'Deny'. Possible values
        /// include: 'Allow', 'Deny'</param>
        /// <param name="direction">Gets or sets the direction of the
        /// rule.InBound or Outbound. The direction specifies if rule will be
        /// evaluated on incoming or outcoming traffic. Possible values
        /// include: 'Inbound', 'Outbound'</param>
        /// <param name="description">Gets or sets a description for this
        /// rule. Restricted to 140 chars.</param>
        /// <param name="sourcePortRange">Gets or sets Source Port or Range.
        /// Integer or range between 0 and 65535. Asterix '*' can also be
        /// used to match all ports.</param>
        /// <param name="destinationPortRange">Gets or sets Destination Port
        /// or Range. Integer or range between 0 and 65535. Asterix '*' can
        /// also be used to match all ports.</param>
        /// <param name="priority">Gets or sets the priority of the rule. The
        /// value can be between 100 and 4096. The priority number must be
        /// unique for each rule in the collection. The lower the priority
        /// number, the higher the priority of the rule.</param>
        /// <param name="provisioningState">Gets provisioning state of the
        /// PublicIP resource Updating/Deleting/Failed</param>
        /// <param name="name">Gets name of the resource that is unique within
        /// a resource group. This name can be used to access the
        /// resource</param>
        /// <param name="etag">A unique read-only string that changes whenever
        /// the resource is updated</param>
        public SecurityRuleInner(string protocol, string sourceAddressPrefix, string destinationAddressPrefix, string access, string direction, string id = default(string), string description = default(string), string sourcePortRange = default(string), string destinationPortRange = default(string), int? priority = default(int?), string provisioningState = default(string), string name = default(string), string etag = default(string))
            : base(id)
        {
            Description = description;
            Protocol = protocol;
            SourcePortRange = sourcePortRange;
            DestinationPortRange = destinationPortRange;
            SourceAddressPrefix = sourceAddressPrefix;
            DestinationAddressPrefix = destinationAddressPrefix;
            Access = access;
            Priority = priority;
            Direction = direction;
            ProvisioningState = provisioningState;
            Name = name;
            Etag = etag;
        }

        /// <summary>
        /// Gets or sets a description for this rule. Restricted to 140 chars.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets Network protocol this rule applies to. Can be Tcp,
        /// Udp or All(*). Possible values include: 'Tcp', 'Udp', '*'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.protocol")]
        public string Protocol { get; set; }

        /// <summary>
        /// Gets or sets Source Port or Range. Integer or range between 0 and
        /// 65535. Asterix '*' can also be used to match all ports.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.sourcePortRange")]
        public string SourcePortRange { get; set; }

        /// <summary>
        /// Gets or sets Destination Port or Range. Integer or range between 0
        /// and 65535. Asterix '*' can also be used to match all ports.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.destinationPortRange")]
        public string DestinationPortRange { get; set; }

        /// <summary>
        /// Gets or sets source address prefix. CIDR or source IP range.
        /// Asterix '*' can also be used to match all source IPs. Default
        /// tags such as 'VirtualNetwork', 'AzureLoadBalancer' and 'Internet'
        /// can also be used. If this is an ingress rule, specifies where
        /// network traffic originates from.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.sourceAddressPrefix")]
        public string SourceAddressPrefix { get; set; }

        /// <summary>
        /// Gets or sets destination address prefix. CIDR or source IP range.
        /// Asterix '*' can also be used to match all source IPs. Default
        /// tags such as 'VirtualNetwork', 'AzureLoadBalancer' and 'Internet'
        /// can also be used.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.destinationAddressPrefix")]
        public string DestinationAddressPrefix { get; set; }

        /// <summary>
        /// Gets or sets network traffic is allowed or denied. Possible values
        /// are 'Allow' and 'Deny'. Possible values include: 'Allow', 'Deny'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.access")]
        public string Access { get; set; }

        /// <summary>
        /// Gets or sets the priority of the rule. The value can be between
        /// 100 and 4096. The priority number must be unique for each rule in
        /// the collection. The lower the priority number, the higher the
        /// priority of the rule.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.priority")]
        public int? Priority { get; set; }

        /// <summary>
        /// Gets or sets the direction of the rule.InBound or Outbound. The
        /// direction specifies if rule will be evaluated on incoming or
        /// outcoming traffic. Possible values include: 'Inbound', 'Outbound'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.direction")]
        public string Direction { get; set; }

        /// <summary>
        /// Gets provisioning state of the PublicIP resource
        /// Updating/Deleting/Failed
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; set; }

        /// <summary>
        /// Gets name of the resource that is unique within a resource group.
        /// This name can be used to access the resource
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets a unique read-only string that changes whenever the
        /// resource is updated
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "etag")]
        public string Etag { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Protocol == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Protocol");
            }
            if (SourceAddressPrefix == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "SourceAddressPrefix");
            }
            if (DestinationAddressPrefix == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "DestinationAddressPrefix");
            }
            if (Access == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Access");
            }
            if (Direction == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Direction");
            }
        }
    }
}
