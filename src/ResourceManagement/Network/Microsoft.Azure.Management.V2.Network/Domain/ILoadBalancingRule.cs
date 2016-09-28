// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
namespace Microsoft.Azure.Management.V2.Network
{

    using Microsoft.Azure.Management.V2.Resource.Core;
    using Microsoft.Azure.Management.Network.Models;
    /// <summary>
    /// An immutable client-side representation of an HTTP load balancing rule.
    /// </summary>
    public interface ILoadBalancingRule  :
        IWrapper<Microsoft.Azure.Management.Network.Models.LoadBalancingRuleInner>,
        IChildResource<Microsoft.Azure.Management.V2.Network.ILoadBalancer>,
        IHasBackendPort,
        IHasFrontend,
        IHasFloatingIp,
        IHasProtocol<string>
    {
        /// <returns>the method of load distribution</returns>
        string LoadDistribution { get; }

        /// <returns>the number of minutes before an inactive connection is closed</returns>
        int? IdleTimeoutInMinutes { get; }

        /// <returns>the load balanced front end port</returns>
        int? FrontendPort { get; }

        /// <returns>the backend associated with the load balancing rule</returns>
        IBackend Backend ();

        /// <returns>the probe associated with the load balancing rule</returns>
        IProbe Probe ();

    }
}