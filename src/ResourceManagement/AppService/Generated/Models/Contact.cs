// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.AppService.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.AppService;
    using Microsoft.Azure.Management.AppService.Fluent;
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Contact information for domain registration. If 'Domain Privacy' option
    /// is not selected then the contact information is made publicly available
    /// through the Whois
    /// directories as per ICANN requirements.
    /// </summary>
    public partial class Contact
    {
        /// <summary>
        /// Initializes a new instance of the Contact class.
        /// </summary>
        public Contact()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Contact class.
        /// </summary>
        /// <param name="email">Email address.</param>
        /// <param name="nameFirst">First name.</param>
        /// <param name="nameLast">Last name.</param>
        /// <param name="phone">Phone number.</param>
        /// <param name="addressMailing">Mailing address.</param>
        /// <param name="fax">Fax number.</param>
        /// <param name="jobTitle">Job title.</param>
        /// <param name="nameMiddle">Middle name.</param>
        /// <param name="organization">Organization.</param>
        public Contact(string email, string nameFirst, string nameLast, string phone, Address addressMailing = default(Address), string fax = default(string), string jobTitle = default(string), string nameMiddle = default(string), string organization = default(string))
        {
            AddressMailing = addressMailing;
            Email = email;
            Fax = fax;
            JobTitle = jobTitle;
            NameFirst = nameFirst;
            NameLast = nameLast;
            NameMiddle = nameMiddle;
            Organization = organization;
            Phone = phone;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets mailing address.
        /// </summary>
        [JsonProperty(PropertyName = "addressMailing")]
        public Address AddressMailing { get; set; }

        /// <summary>
        /// Gets or sets email address.
        /// </summary>
        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets fax number.
        /// </summary>
        [JsonProperty(PropertyName = "fax")]
        public string Fax { get; set; }

        /// <summary>
        /// Gets or sets job title.
        /// </summary>
        [JsonProperty(PropertyName = "jobTitle")]
        public string JobTitle { get; set; }

        /// <summary>
        /// Gets or sets first name.
        /// </summary>
        [JsonProperty(PropertyName = "nameFirst")]
        public string NameFirst { get; set; }

        /// <summary>
        /// Gets or sets last name.
        /// </summary>
        [JsonProperty(PropertyName = "nameLast")]
        public string NameLast { get; set; }

        /// <summary>
        /// Gets or sets middle name.
        /// </summary>
        [JsonProperty(PropertyName = "nameMiddle")]
        public string NameMiddle { get; set; }

        /// <summary>
        /// Gets or sets organization.
        /// </summary>
        [JsonProperty(PropertyName = "organization")]
        public string Organization { get; set; }

        /// <summary>
        /// Gets or sets phone number.
        /// </summary>
        [JsonProperty(PropertyName = "phone")]
        public string Phone { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Email == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Email");
            }
            if (NameFirst == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "NameFirst");
            }
            if (NameLast == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "NameLast");
            }
            if (Phone == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Phone");
            }
            if (AddressMailing != null)
            {
                AddressMailing.Validate();
            }
        }
    }
}
