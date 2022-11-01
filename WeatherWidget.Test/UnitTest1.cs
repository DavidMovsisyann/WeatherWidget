using WeatherWidget.Controllers;
using WeatherWidget.Services;
using System.Text.Json;
using Moq;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using WeatherWidget.Models;

namespace WeatherWidget.Test
{
    public class Tests
    {
        private ApiUsingService _service;
        [SetUp]
        public void SetUp()
        {
            var services = new ServiceCollection();
            services.AddHttpClient("WethForc", httpClient =>
            {
                httpClient.BaseAddress = new Uri("https://api.openweathermap.org");
            });
            var serviceProvider = services.BuildServiceProvider();
            _service = new ApiUsingService(serviceProvider.GetRequiredService<IHttpClientFactory>());
        }
        [Test]
        public void Test1()
        {
            //Arrange         
            int longtidute = 45;
            int latidute = 40;
            string country = "AM";
            int id = 800;
            string name = "Armenia";
            //Act
            var result = _service.GetApiContent(longtidute, latidute).GetAwaiter().GetResult();    
            var GetResult = JsonSerializer.Deserialize<WeatherModel>(result);
            //Assert
            Assert.IsTrue(GetResult.lat == latidute||GetResult.country==country||GetResult.name==name);
        }
    }
}