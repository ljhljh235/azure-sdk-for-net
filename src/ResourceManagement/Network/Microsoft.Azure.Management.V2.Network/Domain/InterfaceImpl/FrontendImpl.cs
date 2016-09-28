// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
namespace Microsoft.Azure.Management.V2.Network
{

    using Microsoft.Azure.Management.V2.Network.PublicFrontend.UpdateDefinition;
    using Microsoft.Azure.Management.V2.Network.PrivateFrontend.UpdateDefinition;
    using Microsoft.Azure.Management.V2.Network.LoadBalancer.Update;
    using Microsoft.Azure.Management.V2.Network.HasPrivateIpAddress.Definition;
    using System.Collections.Generic;
    using Microsoft.Azure.Management.V2.Resource.Core.ChildResourceActions;
    using Microsoft.Azure.Management.Network.Models;
    using Microsoft.Azure.Management.V2.Network.PrivateFrontend.Update;
    using Microsoft.Azure.Management.V2.Network.PrivateFrontend.Definition;
    using Microsoft.Azure.Management.V2.Resource.Core;
    using Microsoft.Azure.Management.V2.Network.PublicFrontend.Update;
    using Microsoft.Azure.Management.V2.Resource.Core.HasSubnet.Definition;
    using Microsoft.Azure.Management.V2.Network.HasPublicIpAddress.Definition;
    using Microsoft.Azure.Management.V2.Network.HasPrivateIpAddress.Update;
    using Microsoft.Azure.Management.V2.Network.HasPublicIpAddress.UpdateDefinition;
    using Microsoft.Azure.Management.V2.Network.LoadBalancer.Definition;
    using Microsoft.Azure.Management.V2.Network.HasPrivateIpAddress.UpdateDefinition;
    using Microsoft.Azure.Management.V2.Resource.Core.ChildResource.Definition;
    using Microsoft.Azure.Management.V2.Network.PublicFrontend.Definition;
    using Microsoft.Azure.Management.V2.Network.HasPublicIpAddress.Update;
    using Microsoft.Azure.Management.V2.Resource.Core.ChildResource.Update;
    public partial class FrontendImpl 
    {
        /// <summary>
        /// Attaches the child definition to the parent resource update.
        /// </summary>
        /// <returns>the next stage of the parent definition</returns>
        Microsoft.Azure.Management.V2.Network.LoadBalancer.Update.IUpdate Microsoft.Azure.Management.V2.Resource.Core.ChildResourceActions.IInUpdateAlt<Microsoft.Azure.Management.V2.Network.LoadBalancer.Update.IUpdate>.Attach () { 
            return this.Attach() as Microsoft.Azure.Management.V2.Network.LoadBalancer.Update.IUpdate;
        }

        /// <returns>the resource ID of the associated public IP address</returns>
        string Microsoft.Azure.Management.V2.Network.IHasPublicIpAddress.PublicIpAddressId
        {
            get
            {
                return this.PublicIpAddressId as string;
            }
        }
        /// <returns>the associated public IP address</returns>
        Microsoft.Azure.Management.V2.Network.IPublicIpAddress Microsoft.Azure.Management.V2.Network.IHasPublicIpAddress.GetPublicIpAddress () { 
            return this.GetPublicIpAddress() as Microsoft.Azure.Management.V2.Network.IPublicIpAddress;
        }

        /// <summary>
        /// Attaches the child definition to the parent resource update.
        /// </summary>
        /// <returns>the next stage of the parent definition</returns>
        Microsoft.Azure.Management.V2.Network.LoadBalancer.Update.IUpdate Microsoft.Azure.Management.V2.Resource.Core.ChildResource.Update.IInUpdate<Microsoft.Azure.Management.V2.Network.LoadBalancer.Update.IUpdate>.Attach () { 
            return this.Attach() as Microsoft.Azure.Management.V2.Network.LoadBalancer.Update.IUpdate;
        }

        /// <summary>
        /// Assigns the specified subnet to this resource.
        /// </summary>
        /// <param name="parentNetworkResourceId">parentNetworkResourceId the resource ID of the virtual network the subnet is part of</param>
        /// <param name="subnetName">subnetName the name of the subnet</param>
        /// <returns>the next stage of the definition</returns>
        Microsoft.Azure.Management.V2.Network.PrivateFrontend.Definition.IWithAttach<Microsoft.Azure.Management.V2.Network.LoadBalancer.Definition.IWithPrivateFrontendOrBackend> Microsoft.Azure.Management.V2.Resource.Core.HasSubnet.Definition.IWithSubnet<Microsoft.Azure.Management.V2.Network.PrivateFrontend.Definition.IWithAttach<Microsoft.Azure.Management.V2.Network.LoadBalancer.Definition.IWithPrivateFrontendOrBackend>>.WithExistingSubnet (string parentNetworkResourceId, string subnetName) { 
            return this.WithExistingSubnet( parentNetworkResourceId,  subnetName) as Microsoft.Azure.Management.V2.Network.PrivateFrontend.Definition.IWithAttach<Microsoft.Azure.Management.V2.Network.LoadBalancer.Definition.IWithPrivateFrontendOrBackend>;
        }

        /// <summary>
        /// Attaches the child definition to the parent resource definiton.
        /// </summary>
        /// <returns>the next stage of the parent definition</returns>
        Microsoft.Azure.Management.V2.Network.LoadBalancer.Definition.IWithPublicFrontendOrBackend Microsoft.Azure.Management.V2.Resource.Core.ChildResource.Definition.IInDefinition<Microsoft.Azure.Management.V2.Network.LoadBalancer.Definition.IWithPublicFrontendOrBackend>.Attach () { 
            return this.Attach() as Microsoft.Azure.Management.V2.Network.LoadBalancer.Definition.IWithPublicFrontendOrBackend;
        }

        /// <returns>the private IP allocation method within the associated subnet for this private frontend</returns>
        string Microsoft.Azure.Management.V2.Network.IPrivateFrontend.PrivateIpAllocationMethod
        {
            get
            {
                return this.PrivateIpAllocationMethod as string;
            }
        }
        /// <returns>the inbound NAT pools on this load balancer that use this frontend, indexed by their names</returns>
        System.Collections.Generic.IDictionary<string,Microsoft.Azure.Management.V2.Network.IInboundNatPool> Microsoft.Azure.Management.V2.Network.IFrontend.InboundNatPools () { 
            return this.InboundNatPools() as System.Collections.Generic.IDictionary<string,Microsoft.Azure.Management.V2.Network.IInboundNatPool>;
        }

        /// <returns>true if the frontend is public, i.e. it has a public IP address associated with it</returns>
        bool? Microsoft.Azure.Management.V2.Network.IFrontend.IsPublic
        {
            get
            {
                return this.IsPublic;
            }
        }
        /// <returns>the inbound NAT rules on this load balancer that use this frontend, indexed by their names</returns>
        System.Collections.Generic.IDictionary<string,Microsoft.Azure.Management.V2.Network.IInboundNatRule> Microsoft.Azure.Management.V2.Network.IFrontend.InboundNatRules () { 
            return this.InboundNatRules() as System.Collections.Generic.IDictionary<string,Microsoft.Azure.Management.V2.Network.IInboundNatRule>;
        }

        /// <summary>
        /// Assigns the specified static private IP address within the associated subnet.
        /// </summary>
        /// <param name="ipAddress">ipAddress a static IP address within the associated private IP range</param>
        /// <returns>the next stage of the definition</returns>
        Microsoft.Azure.Management.V2.Network.PrivateFrontend.UpdateDefinition.IWithAttach<Microsoft.Azure.Management.V2.Network.LoadBalancer.Update.IUpdate> Microsoft.Azure.Management.V2.Network.HasPrivateIpAddress.UpdateDefinition.IWithPrivateIpAddress<Microsoft.Azure.Management.V2.Network.PrivateFrontend.UpdateDefinition.IWithAttach<Microsoft.Azure.Management.V2.Network.LoadBalancer.Update.IUpdate>>.WithPrivateIpAddressStatic (string ipAddress) { 
            return this.WithPrivateIpAddressStatic( ipAddress) as Microsoft.Azure.Management.V2.Network.PrivateFrontend.UpdateDefinition.IWithAttach<Microsoft.Azure.Management.V2.Network.LoadBalancer.Update.IUpdate>;
        }

        /// <summary>
        /// Enables dynamic private IP address allocation within the associated subnet.
        /// </summary>
        /// <returns>the next stage of the definition</returns>
        Microsoft.Azure.Management.V2.Network.PrivateFrontend.UpdateDefinition.IWithAttach<Microsoft.Azure.Management.V2.Network.LoadBalancer.Update.IUpdate> Microsoft.Azure.Management.V2.Network.HasPrivateIpAddress.UpdateDefinition.IWithPrivateIpAddress<Microsoft.Azure.Management.V2.Network.PrivateFrontend.UpdateDefinition.IWithAttach<Microsoft.Azure.Management.V2.Network.LoadBalancer.Update.IUpdate>>.WithPrivateIpAddressDynamic () { 
            return this.WithPrivateIpAddressDynamic() as Microsoft.Azure.Management.V2.Network.PrivateFrontend.UpdateDefinition.IWithAttach<Microsoft.Azure.Management.V2.Network.LoadBalancer.Update.IUpdate>;
        }

        /// <summary>
        /// Assigns the specified static private IP address within the associated subnet.
        /// </summary>
        /// <param name="ipAddress">ipAddress a static IP address within the associated private IP range</param>
        /// <returns>the next stage of the definition</returns>
        Microsoft.Azure.Management.V2.Network.PrivateFrontend.Definition.IWithAttach<Microsoft.Azure.Management.V2.Network.LoadBalancer.Definition.IWithPrivateFrontendOrBackend> Microsoft.Azure.Management.V2.Network.HasPrivateIpAddress.Definition.IWithPrivateIpAddress<Microsoft.Azure.Management.V2.Network.PrivateFrontend.Definition.IWithAttach<Microsoft.Azure.Management.V2.Network.LoadBalancer.Definition.IWithPrivateFrontendOrBackend>>.WithPrivateIpAddressStatic (string ipAddress) { 
            return this.WithPrivateIpAddressStatic( ipAddress) as Microsoft.Azure.Management.V2.Network.PrivateFrontend.Definition.IWithAttach<Microsoft.Azure.Management.V2.Network.LoadBalancer.Definition.IWithPrivateFrontendOrBackend>;
        }

        /// <summary>
        /// Enables dynamic private IP address allocation within the associated subnet.
        /// </summary>
        /// <returns>the next stage of the definition</returns>
        Microsoft.Azure.Management.V2.Network.PrivateFrontend.Definition.IWithAttach<Microsoft.Azure.Management.V2.Network.LoadBalancer.Definition.IWithPrivateFrontendOrBackend> Microsoft.Azure.Management.V2.Network.HasPrivateIpAddress.Definition.IWithPrivateIpAddress<Microsoft.Azure.Management.V2.Network.PrivateFrontend.Definition.IWithAttach<Microsoft.Azure.Management.V2.Network.LoadBalancer.Definition.IWithPrivateFrontendOrBackend>>.WithPrivateIpAddressDynamic () { 
            return this.WithPrivateIpAddressDynamic() as Microsoft.Azure.Management.V2.Network.PrivateFrontend.Definition.IWithAttach<Microsoft.Azure.Management.V2.Network.LoadBalancer.Definition.IWithPrivateFrontendOrBackend>;
        }

        /// <summary>
        /// Assigns the specified static private IP address within the associated subnet.
        /// </summary>
        /// <param name="ipAddress">ipAddress a static IP address within the associated private IP range</param>
        /// <returns>the next stage of the update</returns>
        Microsoft.Azure.Management.V2.Network.PrivateFrontend.Update.IUpdate Microsoft.Azure.Management.V2.Network.HasPrivateIpAddress.Update.IWithPrivateIpAddress<Microsoft.Azure.Management.V2.Network.PrivateFrontend.Update.IUpdate>.WithPrivateIpAddressStatic (string ipAddress) { 
            return this.WithPrivateIpAddressStatic( ipAddress) as Microsoft.Azure.Management.V2.Network.PrivateFrontend.Update.IUpdate;
        }

        /// <summary>
        /// Enables dynamic private IP address allocation within the associated subnet.
        /// </summary>
        /// <returns>the next stage of the update</returns>
        Microsoft.Azure.Management.V2.Network.PrivateFrontend.Update.IUpdate Microsoft.Azure.Management.V2.Network.HasPrivateIpAddress.Update.IWithPrivateIpAddress<Microsoft.Azure.Management.V2.Network.PrivateFrontend.Update.IUpdate>.WithPrivateIpAddressDynamic () { 
            return this.WithPrivateIpAddressDynamic() as Microsoft.Azure.Management.V2.Network.PrivateFrontend.Update.IUpdate;
        }

        /// <returns>the name of the subnet associated with this resource</returns>
        string Microsoft.Azure.Management.V2.Resource.Core.IHasSubnet.SubnetName
        {
            get
            {
                return this.SubnetName as string;
            }
        }
        /// <returns>the resource ID of the virtual network whose subnet is associated with this resource</returns>
        string Microsoft.Azure.Management.V2.Resource.Core.IHasSubnet.NetworkId
        {
            get
            {
                return this.NetworkId as string;
            }
        }
        /// <returns>the private IP address associated with this resource</returns>
        string Microsoft.Azure.Management.V2.Network.IHasPrivateIpAddress.PrivateIpAddress
        {
            get
            {
                return this.PrivateIpAddress as string;
            }
        }
        /// <summary>
        /// Removes the existing reference to a public IP address.
        /// </summary>
        /// <returns>the next stage of the update.</returns>
        Microsoft.Azure.Management.V2.Network.PublicFrontend.Update.IUpdate Microsoft.Azure.Management.V2.Network.HasPublicIpAddress.Update.IWithExistingPublicIpAddress<Microsoft.Azure.Management.V2.Network.PublicFrontend.Update.IUpdate>.WithoutPublicIpAddress () { 
            return this.WithoutPublicIpAddress() as Microsoft.Azure.Management.V2.Network.PublicFrontend.Update.IUpdate;
        }

        /// <summary>
        /// Associates an existing public IP address with the resource.
        /// </summary>
        /// <param name="publicIpAddress">publicIpAddress an existing public IP address</param>
        /// <returns>the next stage of the update</returns>
        Microsoft.Azure.Management.V2.Network.PublicFrontend.Update.IUpdate Microsoft.Azure.Management.V2.Network.HasPublicIpAddress.Update.IWithExistingPublicIpAddress<Microsoft.Azure.Management.V2.Network.PublicFrontend.Update.IUpdate>.WithExistingPublicIpAddress (IPublicIpAddress publicIpAddress) { 
            return this.WithExistingPublicIpAddress( publicIpAddress) as Microsoft.Azure.Management.V2.Network.PublicFrontend.Update.IUpdate;
        }

        /// <summary>
        /// Associates an existing public IP address with the resource.
        /// </summary>
        /// <param name="resourceId">resourceId the resource ID of an existing public IP address</param>
        /// <returns>the next stage of the definition</returns>
        Microsoft.Azure.Management.V2.Network.PublicFrontend.Update.IUpdate Microsoft.Azure.Management.V2.Network.HasPublicIpAddress.Update.IWithExistingPublicIpAddress<Microsoft.Azure.Management.V2.Network.PublicFrontend.Update.IUpdate>.WithExistingPublicIpAddress (string resourceId) { 
            return this.WithExistingPublicIpAddress( resourceId) as Microsoft.Azure.Management.V2.Network.PublicFrontend.Update.IUpdate;
        }

        /// <summary>
        /// Associates an existing public IP address with the resource.
        /// </summary>
        /// <param name="publicIpAddress">publicIpAddress an existing public IP address</param>
        /// <returns>the next stage of the definition</returns>
        Microsoft.Azure.Management.V2.Network.PublicFrontend.Definition.IWithAttach<Microsoft.Azure.Management.V2.Network.LoadBalancer.Definition.IWithPublicFrontendOrBackend> Microsoft.Azure.Management.V2.Network.HasPublicIpAddress.Definition.IWithExistingPublicIpAddress<Microsoft.Azure.Management.V2.Network.PublicFrontend.Definition.IWithAttach<Microsoft.Azure.Management.V2.Network.LoadBalancer.Definition.IWithPublicFrontendOrBackend>>.WithExistingPublicIpAddress (IPublicIpAddress publicIpAddress) { 
            return this.WithExistingPublicIpAddress( publicIpAddress) as Microsoft.Azure.Management.V2.Network.PublicFrontend.Definition.IWithAttach<Microsoft.Azure.Management.V2.Network.LoadBalancer.Definition.IWithPublicFrontendOrBackend>;
        }

        /// <summary>
        /// Associates an existing public IP address with the resource.
        /// </summary>
        /// <param name="resourceId">resourceId the resource ID of an existing public IP address</param>
        /// <returns>the next stage of the definition</returns>
        Microsoft.Azure.Management.V2.Network.PublicFrontend.Definition.IWithAttach<Microsoft.Azure.Management.V2.Network.LoadBalancer.Definition.IWithPublicFrontendOrBackend> Microsoft.Azure.Management.V2.Network.HasPublicIpAddress.Definition.IWithExistingPublicIpAddress<Microsoft.Azure.Management.V2.Network.PublicFrontend.Definition.IWithAttach<Microsoft.Azure.Management.V2.Network.LoadBalancer.Definition.IWithPublicFrontendOrBackend>>.WithExistingPublicIpAddress (string resourceId) { 
            return this.WithExistingPublicIpAddress( resourceId) as Microsoft.Azure.Management.V2.Network.PublicFrontend.Definition.IWithAttach<Microsoft.Azure.Management.V2.Network.LoadBalancer.Definition.IWithPublicFrontendOrBackend>;
        }

        /// <summary>
        /// Associates an existing public IP address with the resource.
        /// </summary>
        /// <param name="publicIpAddress">publicIpAddress an existing public IP address</param>
        /// <returns>the next stage of the definition</returns>
        Microsoft.Azure.Management.V2.Network.PublicFrontend.UpdateDefinition.IWithAttach<Microsoft.Azure.Management.V2.Network.LoadBalancer.Update.IUpdate> Microsoft.Azure.Management.V2.Network.HasPublicIpAddress.UpdateDefinition.IWithExistingPublicIpAddress<Microsoft.Azure.Management.V2.Network.PublicFrontend.UpdateDefinition.IWithAttach<Microsoft.Azure.Management.V2.Network.LoadBalancer.Update.IUpdate>>.WithExistingPublicIpAddress (IPublicIpAddress publicIpAddress) { 
            return this.WithExistingPublicIpAddress( publicIpAddress) as Microsoft.Azure.Management.V2.Network.PublicFrontend.UpdateDefinition.IWithAttach<Microsoft.Azure.Management.V2.Network.LoadBalancer.Update.IUpdate>;
        }

        /// <summary>
        /// Associates an existing public IP address with the resource.
        /// </summary>
        /// <param name="resourceId">resourceId the resource ID of an existing public IP address</param>
        /// <returns>the next stage of the definition</returns>
        Microsoft.Azure.Management.V2.Network.PublicFrontend.UpdateDefinition.IWithAttach<Microsoft.Azure.Management.V2.Network.LoadBalancer.Update.IUpdate> Microsoft.Azure.Management.V2.Network.HasPublicIpAddress.UpdateDefinition.IWithExistingPublicIpAddress<Microsoft.Azure.Management.V2.Network.PublicFrontend.UpdateDefinition.IWithAttach<Microsoft.Azure.Management.V2.Network.LoadBalancer.Update.IUpdate>>.WithExistingPublicIpAddress (string resourceId) { 
            return this.WithExistingPublicIpAddress( resourceId) as Microsoft.Azure.Management.V2.Network.PublicFrontend.UpdateDefinition.IWithAttach<Microsoft.Azure.Management.V2.Network.LoadBalancer.Update.IUpdate>;
        }

        /// <summary>
        /// Attaches the child definition to the parent resource definition.
        /// </summary>
        /// <returns>the next stage of the parent definition</returns>
        Microsoft.Azure.Management.V2.Network.LoadBalancer.Definition.IWithPrivateFrontendOrBackend Microsoft.Azure.Management.V2.Resource.Core.ChildResourceActions.IInDefinitionAlt<Microsoft.Azure.Management.V2.Network.LoadBalancer.Definition.IWithPrivateFrontendOrBackend>.Attach () { 
            return this.Attach() as Microsoft.Azure.Management.V2.Network.LoadBalancer.Definition.IWithPrivateFrontendOrBackend;
        }

        /// <returns>the associated load balancing rules from this load balancer, indexed by their names</returns>
        System.Collections.Generic.IDictionary<string,Microsoft.Azure.Management.V2.Network.ILoadBalancingRule> Microsoft.Azure.Management.V2.Network.IHasLoadBalancingRules.LoadBalancingRules () { 
            return this.LoadBalancingRules() as System.Collections.Generic.IDictionary<string,Microsoft.Azure.Management.V2.Network.ILoadBalancingRule>;
        }

        /// <summary>
        /// Assigns the specified subnet to this private frontend of the internal load balancer.
        /// </summary>
        /// <param name="network">network the virtual network the subnet exists in</param>
        /// <param name="subnetName">subnetName the name of a subnet</param>
        /// <returns>the next stage of the definition</returns>
        Microsoft.Azure.Management.V2.Network.PrivateFrontend.UpdateDefinition.IWithAttach<Microsoft.Azure.Management.V2.Network.LoadBalancer.Update.IUpdate> Microsoft.Azure.Management.V2.Network.PrivateFrontend.UpdateDefinition.IWithSubnet<Microsoft.Azure.Management.V2.Network.LoadBalancer.Update.IUpdate>.WithExistingSubnet (INetwork network, string subnetName) { 
            return this.WithExistingSubnet( network,  subnetName) as Microsoft.Azure.Management.V2.Network.PrivateFrontend.UpdateDefinition.IWithAttach<Microsoft.Azure.Management.V2.Network.LoadBalancer.Update.IUpdate>;
        }

        /// <summary>
        /// Assigns the specified subnet to this private frontend of an internal load balancer.
        /// </summary>
        /// <param name="network">network the virtual network the subnet exists in</param>
        /// <param name="subnetName">subnetName the name of a subnet</param>
        /// <returns>the next stage of the definition</returns>
        Microsoft.Azure.Management.V2.Network.PrivateFrontend.Definition.IWithAttach<Microsoft.Azure.Management.V2.Network.LoadBalancer.Definition.IWithPrivateFrontendOrBackend> Microsoft.Azure.Management.V2.Network.PrivateFrontend.Definition.IWithSubnet<Microsoft.Azure.Management.V2.Network.LoadBalancer.Definition.IWithPrivateFrontendOrBackend>.WithExistingSubnet (INetwork network, string subnetName) { 
            return this.WithExistingSubnet( network,  subnetName) as Microsoft.Azure.Management.V2.Network.PrivateFrontend.Definition.IWithAttach<Microsoft.Azure.Management.V2.Network.LoadBalancer.Definition.IWithPrivateFrontendOrBackend>;
        }

        /// <returns>the name of this child object</returns>
        string Microsoft.Azure.Management.V2.Resource.Core.IChildResource<Microsoft.Azure.Management.V2.Network.ILoadBalancer>.Name
        {
            get
            {
                return this.Name as string;
            }
        }
        /// <summary>
        /// Assigns the specified subnet to this private frontend of the internal load balancer.
        /// </summary>
        /// <param name="network">network the virtual network the subnet exists in</param>
        /// <param name="subnetName">subnetName the name of a subnet</param>
        /// <returns>the next stage of the definition</returns>
        Microsoft.Azure.Management.V2.Network.PrivateFrontend.Update.IUpdate Microsoft.Azure.Management.V2.Network.PrivateFrontend.Update.IWithSubnet.WithExistingSubnet (INetwork network, string subnetName) { 
            return this.WithExistingSubnet( network,  subnetName) as Microsoft.Azure.Management.V2.Network.PrivateFrontend.Update.IUpdate;
        }

    }
}