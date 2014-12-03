
namespace OxxaDotNet.Responses {
    public class DomainCheckResponse {

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
}
