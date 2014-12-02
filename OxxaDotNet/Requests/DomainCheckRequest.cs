using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OxxaDotNet.Requests {
    public class DomainCheckRequest {
        /// <summary>
        /// The TLD (Top Level Domain): 'org' in example.org.
        /// </summary>
        /// <value>
        /// The TLD.
        /// </value>
        public string Tld { get; set; }
        /// <summary>
        /// The SLD (Second Level Domain): 'example' in example.org.
        /// </summary>
        /// <value>
        /// The SLD.
        /// </value>
        public string Sld { get; set; }
    }
}
