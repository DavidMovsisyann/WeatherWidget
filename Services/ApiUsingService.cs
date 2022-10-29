using System.Text.Json;

namespace WeatherWidget.Services
{
    public class ApiUsingService
    {
        IHttpClientFactory _httpClientFactory;

        public ApiUsingService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<Stream> GetApiContent(float longtidute,float latidute)
        {
            string Url = $"data/2.5/weather?lat={latidute}&lon={longtidute}&appid=6cd73d4dbb7ae06b0adde9ce51f9e0f0";

            var httpClient = _httpClientFactory.CreateClient("WethForc");
            var httpResponseMessage = await httpClient.GetAsync(Url);         
            return await httpResponseMessage.Content.ReadAsStreamAsync();
        }
    }
}
