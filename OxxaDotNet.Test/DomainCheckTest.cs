using System;
using Xunit;

namespace OxxaDotNet.Test {

    public class DomainCheckTest {
        [Fact]
        public void DomainCheck() {
            var testDomainSld = "chatbotratchet";
            var testDomainTld = "com";

            var client = new OxxaClient(Environment.GetEnvironmentVariable("oxxa_auth_username"),
                                        Environment.GetEnvironmentVariable("oxxa_auth_password"));
            var response = client.DomainCheck(new Requests.DomainCheckRequest() {
                Sld = testDomainSld,
                Tld = testDomainTld
            });

            Assert.Equal("domain_check", response.Command);
            Assert.Equal("Domeinnaam is bezet.", response.StatusDescription);
            Assert.Equal("XMLOK 10", response.StatusCode);
            Assert.Equal(testDomainTld, response.Tld);
            Assert.Equal(testDomainSld, response.Sld);
            Assert.Equal(0.0, response.Price);
            Assert.Equal(true, response.Done);
            Assert.Equal(true, response.OrderComplete);
        }
    }
}
