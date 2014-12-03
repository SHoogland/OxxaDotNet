using System;

namespace OxxaDotNet.Requests {
    public class DomainListRequest {

        /// <summary>
        /// Gets or sets the start.
        /// </summary>
        /// <value>
        /// The start. (default = 0)
        /// </value>
        public int Start { get; set; }

        /// <summary>
        /// Gets or sets the records.
        /// </summary>
        /// <value>
        /// The records. (default = 25, all = -1)
        /// </value>
        public int Records { get; set; }

        /// <summary>
        /// Gets or sets the name of the sort.
        /// </summary>
        /// <value>
        /// The name of the sort.
        /// </value>
        public string SortName { get; set; }

        /// <summary>
        /// Gets or sets the sort order.
        /// </summary>
        /// <value>
        /// The sort order.
        /// </value>
        public string SortOrder { get; set; }

        /// <summary>
        /// The SLD (Second Level Domain): 'example' in example.org.
        /// </summary>
        /// <value>
        /// The SLD.
        /// </value>
        public string Sld { get; set; }

        /// <summary>
        /// The TLD (Top Level Domain): 'org' in example.org.
        /// </summary>
        /// <value>
        /// The TLD.
        /// </value>
        public string Tld { get; set; }

        /// <summary>
        /// Gets or sets the ns group.
        /// </summary>
        /// <value>
        /// The ns group.
        /// </value>
        public string NsGroup { get; set; }

        /// <summary>
        /// Gets or sets the identity.
        /// </summary>
        /// <value>
        /// The identity.
        /// </value>
        public string Identity { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [automatic renew].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [automatic renew]; otherwise, <c>false</c>.
        /// </value>
        public bool AutoRenew { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="DomainListRequest" /> is lock.
        /// </summary>
        /// <value>
        ///   <c>true</c> if lock; otherwise, <c>false</c>.
        /// </value>
        public bool Lock { get; set; }

        /// <summary>
        /// Gets or sets the expire date.
        /// </summary>
        /// <value>
        /// The expire date.
        /// </value>
        public DateTime ExpireDate { get; set; }

        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        /// <value>
        /// The status.
        /// </value>
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="DomainListRequest"/> is transferd in the last 24 hours.
        /// </summary>
        /// <value>
        ///   <c>true</c> if transferd; otherwise, <c>false</c>.
        /// </value>
        public bool Transferd { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="DomainListRequest"/> is deleted in the last 24 hours.
        /// </summary>
        /// <value>
        ///   <c>true</c> if deleted; otherwise, <c>false</c>.
        /// </value>
        public bool Deleted { get; set; }
    }
}
