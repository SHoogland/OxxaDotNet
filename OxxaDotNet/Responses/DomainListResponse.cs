using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OxxaDotNet.Responses {
    public class DomainListResponse {

        /// <summary>
        /// Gets or sets the order identifier.
        /// </summary>
        /// <value>
        /// The order identifier.
        /// </value>
        public string OrderId { get; set; }

        /// <summary>
        /// Gets or sets the command.
        /// </summary>
        /// <value>
        /// The command.
        /// </value>
        public string Command { get; set; }

        /// <summary>
        /// Gets or sets the status code.
        /// </summary>
        /// <value>
        /// The status code.
        /// </value>
        public string StatusCode { get; set; }

        /// <summary>
        /// Gets or sets the status description.
        /// </summary>
        /// <value>
        /// The status description.
        /// </value>
        public string StatusDescription { get; set; }

        /// <summary>
        /// Gets or sets the price.
        /// </summary>
        /// <value>
        /// The price.
        /// </value>
        public double Price { get; set; }

        /// <summary>
        /// Gets or sets the details.
        /// </summary>
        /// <value>
        /// The details.
        /// </value>
        public string details { get; set; }

        /// <summary>
        /// Gets or sets the domains total.
        /// </summary>
        /// <value>
        /// The domains total.
        /// </value>
        public int DomainsTotal { get; set; }

        /// <summary>
        /// Gets or sets the domains found.
        /// </summary>
        /// <value>
        /// The domains found.
        /// </value>
        public int DomainsFound { get; set; }

        /// <summary>
        /// Gets or sets the oxxa domains.
        /// </summary>
        /// <value>
        /// The oxxa domains.
        /// </value>
        public List<OxxaDomain> OxxaDomains { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [order complete].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [order complete]; otherwise, <c>false</c>.
        /// </value>
        public bool OrderComplete { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="DomainCheckResponse"/> is done.
        /// </summary>
        /// <value>
        ///   <c>true</c> if done; otherwise, <c>false</c>.
        /// </value>
        public bool Done { get; set; }
    }

    public class OxxaDomain {

        /// <summary>
        /// Gets or sets the name of the domain.
        /// </summary>
        /// <value>
        /// The name of the domain.
        /// </value>
        public string DomainName { get; set; }

        /// <summary>
        /// Gets or sets the ns group.
        /// </summary>
        /// <value>
        /// The ns group.
        /// </value>
        public string NsGroup { get; set; }

        /// <summary>
        /// Gets or sets the identity registrant.
        /// </summary>
        /// <value>
        /// The identity registrant.
        /// </value>
        public string IdentityRegistrant { get; set; }

        /// <summary>
        /// Gets or sets the identity admin.
        /// </summary>
        /// <value>
        /// The identity admin.
        /// </value>
        public string IdentityAdmin { get; set; }

        /// <summary>
        /// Gets or sets the identity tech.
        /// </summary>
        /// <value>
        /// The identity tech.
        /// </value>
        public string IdentityTech { get; set; }

        /// <summary>
        /// Gets or sets the identity billing.
        /// </summary>
        /// <value>
        /// The identity billing.
        /// </value>
        public string IdentityBilling { get; set; }

        /// <summary>
        /// Gets or sets the expire date.
        /// </summary>
        /// <value>
        /// The expire date.
        /// </value>
        public DateTime ExpireDate { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [automatic renew].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [automatic renew]; otherwise, <c>false</c>.
        /// </value>
        public bool AutoRenew { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="OxxaDomain"/> is lock.
        /// </summary>
        /// <value>
        ///   <c>true</c> if lock; otherwise, <c>false</c>.
        /// </value>
        public bool Lock { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [use trustee].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [use trustee]; otherwise, <c>false</c>.
        /// </value>
        public bool UseTrustee { get; set; }
    }
}
