using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OxxaDotNet.Responses {
    public class DomainCheckResponse {
        public string OrderId { get; set; }
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
        public string StatusCode { get; set; }
        public string StatusDescription { get; set; }
        public double Price { get; set; }
        public string details { get; set; }
        public bool OrderComplete { get; set; }
        public bool Done { get; set; }
    }
}
