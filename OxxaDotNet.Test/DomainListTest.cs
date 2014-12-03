﻿using System;
using Xunit;

namespace OxxaDotNet.Test {
    public class DomainListTest {
        [Fact]
        public void DomainList() {
            var client = new OxxaClient(Environment.GetEnvironmentVariable("oxxa_auth_username"),
                                        Environment.GetEnvironmentVariable("oxxa_auth_password"));
            var response = client.DomainList(new Requests.DomainListRequest() { });

            Assert.Equal("domain_list", response.Command);
            Assert.Equal("", response.details);
            Assert.NotNull(response.OxxaDomains);
        }
    }
}
