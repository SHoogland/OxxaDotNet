using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OxxaDotNet {
    public class OxxaEndpoints {
        private static string EndpointHost = "https://api.oxxa.com/command.php?apiuser={0}&apipassword={1}";
        public static string DomainCheckEndpointFormat { get { return String.Format("{0}&command=domain_check&tld={{2}}&sld={{3}}", EndpointHost); } }

    }
}
