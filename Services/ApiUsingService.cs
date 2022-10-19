namespace WeatherWidget.Services
{
    public class ApiUsingService
    {
        IHttpClientFactory _httpClientFactory;
        private string Url = @"https://api.openweathermap.org/data/2.5/weather?lat=<lattitude>&lon=<longitude>&appid=6cd73d4dbb7ae06b0adde9ce51f9e0f0";
        
        public ApiUsingService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public string GetApiContent()
        {
            var client = _httpClientFactory.CreateClient();
            var response = client.GetAsync(Url);
            return response.Result.ToString();
        }
    }
}
