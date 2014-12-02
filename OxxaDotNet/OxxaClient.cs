using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using OxxaDotNet.Requests;
using OxxaDotNet.Responses;

namespace OxxaDotNet {
    public class OxxaClient {
        private readonly string _userName;
        private readonly string _password;

        /// <summary>
        /// Creates a new OxxaClient, you can pass in an optional
        /// username and password, or by default it will look in the web/app config
        /// file appSettings for 'oxxa_auth_username' and 'oxxa_auth_password'
        /// </summary>
        /// <param name="userName">Oxxa account username.</param>
        /// <param name="password">Oxxa account password (this can(should) be a MD5 hashed string).</param>
        public OxxaClient(string userName, string password) {
            _userName = userName ?? OxxaApiConfig.UserName;
            _password = password ?? OxxaApiConfig.Password;
        }

        public DomainCheckResponse DomainCheck(DomainCheckRequest request) {
            var xmlResponse = new XmlDocument();
            xmlResponse.Load(string.Format(OxxaEndpoints.DomainCheckEndpointFormat, _userName, _password, request.Tld, request.Sld));
            var orderNode = xmlResponse.SelectSingleNode("channel/order");

            var response = new DomainCheckResponse();
            response.OrderId = orderNode.SelectSingleNode("order_id").InnerText;
            response.Command = orderNode.SelectSingleNode("command").InnerText;
            response.Sld = orderNode.SelectSingleNode("sld").InnerText;
            response.Tld = orderNode.SelectSingleNode("tld").InnerText;
            response.StatusCode = orderNode.SelectSingleNode("status_code").InnerText;
            response.StatusDescription = orderNode.SelectSingleNode("status_description").InnerText;
            response.Price = double.Parse(orderNode.SelectSingleNode("price").InnerText);
            response.OrderComplete = orderNode.SelectSingleNode("order_complete").InnerText == "TRUE" ? true : false;
            response.Done = orderNode.SelectSingleNode("done").InnerText == "TRUE" ? true : false;

            return response;
        }
    }
}
