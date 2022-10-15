using Microsoft.AspNetCore.Mvc;
using WeatherWidget.Services;

namespace WeatherWidget.Controllers
{
    [ApiController]
    [Route("controller")]
    public class WeatherController : Controller
    {
        [HttpGet("Url")]
        public string GetWeather(string Url)
        {
            return ApiUsingService.GetApiContent(Url);
        }
    }
}
