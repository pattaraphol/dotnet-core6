using demo2;
using demo2.Controllers;
using demo2.Models;
using demo2.Repository;

using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace TestDemo {

    public class UnitTest1 : IClassFixture<WebApplicationFactory<Program>> {
        

        private readonly WebApplicationFactory<Program> _factory;

        public UnitTest1(WebApplicationFactory<Program> factory) {
            _factory = factory;
        }

        [Fact]
        public async Task Get_EndpointsReturnSuccessAndCorrectContentType() {

            // Arrange
            var client = _factory.CreateClient();

            // Act
            HttpResponseMessage response = await client.GetAsync("/api/notes");
            string responseBody = await response.Content.ReadAsStringAsync();

            // Assert
            response.EnsureSuccessStatusCode();

            // You should replace the expectedContent with the actual expected content from your API
            string expectedContent = "[{\"id\":1,\"name\":\"Note 1\"},{\"id\":2,\"name\":\"Note 2\"}]";
            Assert.Equal(expectedContent, responseBody);
        }
    }
}