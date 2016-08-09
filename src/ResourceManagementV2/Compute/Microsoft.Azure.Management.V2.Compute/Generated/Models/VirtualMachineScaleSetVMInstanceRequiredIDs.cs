// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Compute.Models
{
    using System.Linq;

    /// <summary>
    /// Specifies the list of virtual machine scale set instance IDs.
    /// </summary>
    public partial class VirtualMachineScaleSetVMInstanceRequiredIDs
    {
        /// <summary>
        /// Initializes a new instance of the
        /// VirtualMachineScaleSetVMInstanceRequiredIDs class.
        /// </summary>
        public VirtualMachineScaleSetVMInstanceRequiredIDs() { }

        /// <summary>
        /// Initializes a new instance of the
        /// VirtualMachineScaleSetVMInstanceRequiredIDs class.
        /// </summary>
        /// <param name="instanceIds">the virtual machine scale set instance
        /// ids.</param>
        public VirtualMachineScaleSetVMInstanceRequiredIDs(System.Collections.Generic.IList<string> instanceIds)
        {
            InstanceIds = instanceIds;
        }

        /// <summary>
        /// Gets or sets the virtual machine scale set instance ids.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "instanceIds")]
        public System.Collections.Generic.IList<string> InstanceIds { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (InstanceIds == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "InstanceIds");
            }
        }
    }
}
