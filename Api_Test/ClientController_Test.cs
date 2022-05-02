using Xunit;
using System.Reflection;
using CallApp.Api.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace Api_Test
{
    public class ClientController_Test
    {
        [Fact]
        public void Search_Test()
        {
            var method = typeof(ClientController).GetMethod("Search");
            var attribute = method?.GetCustomAttribute(typeof(HttpGetAttribute)) as HttpGetAttribute;

            Assert.True(method != null, "Method not found");
            Assert.True(attribute != null, "Attribute not found");
            Assert.False(attribute?.Template != "Search", "Not corect route");
        }

        [Fact]
        public void BaseInfo_Test()
        {
            var method = typeof(ClientController).GetMethod("BaseInfo");
            var attribute = method?.GetCustomAttribute(typeof(HttpGetAttribute)) as HttpGetAttribute;

            Assert.True(method != null, "Method not found");
            Assert.True(attribute != null, "Attribute not found");
            Assert.False(attribute?.Template != "BaseInfo", "Not corect route");
        }

        [Fact]
        public void Info_Test()
        {
            var method = typeof(ClientController).GetMethod("Info");
            var attribute = method?.GetCustomAttribute(typeof(HttpGetAttribute)) as HttpGetAttribute;

            Assert.True(method != null, "Method not found");
            Assert.True(attribute != null, "Attribute not found");
            Assert.False(attribute?.Template != "Info", "Not corect route");
        }
    }
}