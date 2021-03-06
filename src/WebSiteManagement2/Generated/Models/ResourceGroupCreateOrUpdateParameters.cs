// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;

namespace Microsoft.Azure.Management.WebSites.Models
{
    /// <summary>
    /// Parameters supplied to the Create or Update operation for the resource
    /// group.
    /// </summary>
    public partial class ResourceGroupCreateOrUpdateParameters
    {
        private string _location;
        
        /// <summary>
        /// Required. The location of the resource group. It cannot be changed
        /// after the resource group has been created. Has to be one of the
        /// supported Azure Locations, such as West US, East US, West Europe,
        /// East Asia, or on-premise/alternate provider location names.
        /// </summary>
        public string Location
        {
            get { return this._location; }
            set { this._location = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the
        /// ResourceGroupCreateOrUpdateParameters class.
        /// </summary>
        public ResourceGroupCreateOrUpdateParameters()
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the
        /// ResourceGroupCreateOrUpdateParameters class with required
        /// arguments.
        /// </summary>
        public ResourceGroupCreateOrUpdateParameters(string location)
            : this()
        {
            if (location == null)
            {
                throw new ArgumentNullException("location");
            }
            this.Location = location;
        }
    }
}
