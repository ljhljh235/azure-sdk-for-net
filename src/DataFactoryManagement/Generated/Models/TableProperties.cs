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
using System.Collections.Generic;
using System.Linq;
using Microsoft.Azure.Management.DataFactories.Models;
using Microsoft.WindowsAzure.Common.Internals;

namespace Microsoft.Azure.Management.DataFactories.Models
{
    /// <summary>
    /// Table properties.
    /// </summary>
    public partial class TableProperties
    {
        private Availability _availability;
        
        /// <summary>
        /// Required. Scheduler of the table.
        /// </summary>
        public Availability Availability
        {
            get { return this._availability; }
            set { this._availability = value; }
        }
        
        private System.DateTime? _createTime;
        
        /// <summary>
        /// Optional. The time it is created.
        /// </summary>
        public System.DateTime? CreateTime
        {
            get { return this._createTime; }
            set { this._createTime = value; }
        }
        
        private string _description;
        
        /// <summary>
        /// Optional. Table description.
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }
        
        private string _errorMessage;
        
        /// <summary>
        /// Optional. Error in processing table request.
        /// </summary>
        public string ErrorMessage
        {
            get { return this._errorMessage; }
            set { this._errorMessage = value; }
        }
        
        private TableLocation _location;
        
        /// <summary>
        /// Required. Storage of the table.
        /// </summary>
        public TableLocation Location
        {
            get { return this._location; }
            set { this._location = value; }
        }
        
        private Policy _policy;
        
        /// <summary>
        /// Optional. Policy applied to the table.
        /// </summary>
        public Policy Policy
        {
            get { return this._policy; }
            set { this._policy = value; }
        }
        
        private string _provisioningState;
        
        /// <summary>
        /// Optional. The provisioning state of the table.
        /// </summary>
        public string ProvisioningState
        {
            get { return this._provisioningState; }
            set { this._provisioningState = value; }
        }
        
        private bool? _published;
        
        /// <summary>
        /// Optional. Table is published to Enterprise Data Directory.
        /// </summary>
        public bool? Published
        {
            get { return this._published; }
            set { this._published = value; }
        }
        
        private IList<DataElement> _structure;
        
        /// <summary>
        /// Optional. Columns that define the structure of the table.
        /// </summary>
        public IList<DataElement> Structure
        {
            get { return this._structure; }
            set { this._structure = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the TableProperties class.
        /// </summary>
        public TableProperties()
        {
            this.Structure = new LazyList<DataElement>();
        }
        
        /// <summary>
        /// Initializes a new instance of the TableProperties class with
        /// required arguments.
        /// </summary>
        public TableProperties(TableLocation location, Availability availability)
            : this()
        {
            if (location == null)
            {
                throw new ArgumentNullException("location");
            }
            if (availability == null)
            {
                throw new ArgumentNullException("availability");
            }
            this.Location = location;
            this.Availability = availability;
        }
    }
}