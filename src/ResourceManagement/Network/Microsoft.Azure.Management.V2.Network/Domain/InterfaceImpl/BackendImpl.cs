// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
namespace Microsoft.Azure.Management.V2.Network
{

    using Microsoft.Azure.Management.V2.Network.Backend.Update;
    using System.Collections.Generic;
    using Microsoft.Azure.Management.V2.Network.LoadBalancer.Update;
    using Microsoft.Azure.Management.V2.Network.LoadBalancer.Definition;
    using Microsoft.Azure.Management.Network.Models;
    using Microsoft.Azure.Management.V2.Resource.Core.ChildResource.Definition;
    using Microsoft.Azure.Management.V2.Resource.Core;
    using Microsoft.Azure.Management.V2.Network.Backend.UpdateDefinition;
    using Microsoft.Azure.Management.V2.Resource.Core.ChildResource.Update;
    using Microsoft.Azure.Management.V2.Network.Backend.Definition;
    public partial class BackendImpl 
    {
        /// <summary>
        /// Attaches the child definition to the parent resource update.
        /// </summary>
        /// <returns>the next stage of the parent definition</returns>
        Microsoft.Azure.Management.V2.Network.LoadBalancer.Update.IUpdate Microsoft.Azure.Management.V2.Resource.Core.ChildResource.Update.IInUpdate<Microsoft.Azure.Management.V2.Network.LoadBalancer.Update.IUpdate>.Attach () { 
            return this.Attach() as Microsoft.Azure.Management.V2.Network.LoadBalancer.Update.IUpdate;
        }

        /// <returns>the associated load balancing rules from this load balancer, indexed by their names</returns>
        System.Collections.Generic.IDictionary<string,Microsoft.Azure.Management.V2.Network.ILoadBalancingRule> Microsoft.Azure.Management.V2.Network.IHasLoadBalancingRules.LoadBalancingRules () { 
            return this.LoadBalancingRules() as System.Collections.Generic.IDictionary<string,Microsoft.Azure.Management.V2.Network.ILoadBalancingRule>;
        }

        /// <returns>a list of the resource IDs of the virtual machines associated with this backend</returns>
        System.Collections.Generic.ISet<string> Microsoft.Azure.Management.V2.Network.IBackend.GetVirtualMachineIds () { 
            return this.GetVirtualMachineIds() as System.Collections.Generic.ISet<string>;
        }

        /// <returns>a map of names of the IP configurations of network interfaces assigned to this backend,</returns>
        /// <returns>indexed by their NIC's resource id</returns>
        System.Collections.Generic.IDictionary<string,string> Microsoft.Azure.Management.V2.Network.IBackend.BackendNicIpConfigurationNames
        {
            get
            {
                return this.BackendNicIpConfigurationNames as System.Collections.Generic.IDictionary<string,string>;
            }
        }
        /// <summary>
        /// Attaches the child definition to the parent resource definiton.
        /// </summary>
        /// <returns>the next stage of the parent definition</returns>
        Microsoft.Azure.Management.V2.Network.LoadBalancer.Definition.IWithBackendOrProbe Microsoft.Azure.Management.V2.Resource.Core.ChildResource.Definition.IInDefinition<Microsoft.Azure.Management.V2.Network.LoadBalancer.Definition.IWithBackendOrProbe>.Attach () { 
            return this.Attach() as Microsoft.Azure.Management.V2.Network.LoadBalancer.Definition.IWithBackendOrProbe;
        }

        /// <returns>the name of this child object</returns>
        string Microsoft.Azure.Management.V2.Resource.Core.IChildResource<Microsoft.Azure.Management.V2.Network.ILoadBalancer>.Name
        {
            get
            {
                return this.Name as string;
            }
        }
    }
}