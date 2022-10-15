namespace WeatherWidget.Services
{
    public static class ApiUsingService
    {
       static HttpClient client = new HttpClient();
        
        public static string GetApiContent(string Url)
        {
            client.DefaultRequestHeaders.Accept.Clear();

            string result = client.GetAsync(Url).Result.ToString();
            return result;
        }
    }
}
