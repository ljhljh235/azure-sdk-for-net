// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
namespace Microsoft.Azure.Management.Network.Fluent
{
    using Microsoft.Azure.Management.Network.Fluent.RouteTable.Update;
    using Microsoft.Azure.Management.Network.Fluent.Models;
    using Microsoft.Azure.Management.ResourceManager.Fluent.Core;
    using Microsoft.Azure.Management.ResourceManager.Fluent.Core.ResourceActions;
    using System.Collections.Generic;

    /// <summary>
    /// Entry point for route table management.
    /// </summary>
    public interface IRouteTable  :
        IGroupableResource<Microsoft.Azure.Management.Network.Fluent.INetworkManager,Models.RouteTableInner>,
        IRefreshable<Microsoft.Azure.Management.Network.Fluent.IRouteTable>,
        IUpdatable<RouteTable.Update.IUpdate>,
        IHasAssociatedSubnets
    {
        /// <summary>
        /// Gets the routes of this route table.
        /// </summary>
        System.Collections.Generic.IReadOnlyDictionary<string,Microsoft.Azure.Management.Network.Fluent.IRoute> Routes { get; }
    }
}