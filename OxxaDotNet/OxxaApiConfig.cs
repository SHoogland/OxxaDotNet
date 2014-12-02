using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace OxxaDotNet {
    public static class OxxaApiConfig {
        static OxxaApiConfig() {
            UserName = ConfigurationManager.AppSettings["oxxa_auth_username"] ?? "";
            Password = ConfigurationManager.AppSettings["oxxa_auth_password"] ?? "";
        }

        public static string UserName { get; set; }
        public static string Password { get; set; }
    }
}
