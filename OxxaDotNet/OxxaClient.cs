using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OxxaDotNet {
    public class OxxaClient {
        private readonly string _userName;
        private readonly string _password;
        public OxxaClient(string userName, string password) {
            _userName = userName ?? OxxaApiConfig.UserName;
            _password = password ?? OxxaApiConfig.Password;
        }
    }
}
