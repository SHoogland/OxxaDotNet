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

            if (orderNode.SelectSingleNode("details") != null) {
                response.details = orderNode.SelectSingleNode("details").InnerText;
            }
            else {
                response.details = "";
            }

            return response;
        }

        public DomainListResponse DomainList(DomainListRequest request) {
            var xmlResponse = new XmlDocument();
            xmlResponse.Load(string.Format(OxxaEndpoints.DomainListEndpointFormat, _userName, _password));
            var orderNode = xmlResponse.SelectSingleNode("channel/order");

            var response = new DomainListResponse();
            response.OrderId = orderNode.SelectSingleNode("order_id").InnerText;
            response.Command = orderNode.SelectSingleNode("command").InnerText;
            //response.Sld = orderNode.SelectSingleNode("sld").InnerText ?? "";
            //response.Tld = orderNode.SelectSingleNode("tld").InnerText ?? "";
            response.StatusCode = orderNode.SelectSingleNode("status_code").InnerText;
            response.StatusDescription = orderNode.SelectSingleNode("status_description").InnerText;
            response.Price = double.Parse(orderNode.SelectSingleNode("price").InnerText);
            response.OrderComplete = orderNode.SelectSingleNode("order_complete").InnerText == "TRUE" ? true : false;
            response.Done = orderNode.SelectSingleNode("done").InnerText == "TRUE" ? true : false;

            var detailsNode = orderNode.SelectSingleNode("details");
            if (detailsNode != null) {
                if (detailsNode.HasChildNodes) {
                    response.DomainsTotal = int.Parse(detailsNode.SelectSingleNode("domains_total").InnerText);
                    response.DomainsFound = int.Parse(detailsNode.SelectSingleNode("domains_found").InnerText);

                    response.OxxaDomains = new List<OxxaDomain>();
                    foreach (XmlNode domain in detailsNode.SelectNodes("domain")) {
                        var oxxaDomain = new OxxaDomain();
                        oxxaDomain.DomainName = domain.SelectSingleNode("domainname").InnerText;
                        oxxaDomain.NsGroup = domain.SelectSingleNode("nsgroup").InnerText;
                        oxxaDomain.IdentityRegistrant = domain.SelectSingleNode("identity-registrant").InnerText;
                        oxxaDomain.IdentityAdmin = domain.SelectSingleNode("identity-admin").InnerText;
                        oxxaDomain.IdentityTech = domain.SelectSingleNode("identity-tech").InnerText;
                        oxxaDomain.IdentityBilling = domain.SelectSingleNode("identity-billing").InnerText;
                        oxxaDomain.ExpireDate = DateTime.Parse(domain.SelectSingleNode("expire_date").InnerText);
                        oxxaDomain.AutoRenew = domain.SelectSingleNode("autorenew").InnerText == "Y" ? true : false;
                        if (domain.SelectSingleNode("lock") != null) {
                            oxxaDomain.Lock = domain.SelectSingleNode("lock").InnerText == "Y" ? true : false;
                        }
                        else {
                            oxxaDomain.Lock = false;
                        }
                        oxxaDomain.UseTrustee = domain.SelectSingleNode("usetrustee").InnerText == "Y" ? true : false;
                        response.OxxaDomains.Add(oxxaDomain);
                    }
                    response.details = "";
                }
                else {
                    response.details = detailsNode.InnerText;
                }
            }

            return response;
        }
    }
}
