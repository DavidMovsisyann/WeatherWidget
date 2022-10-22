using Microsoft.AspNetCore.Mvc;
using WeatherWidget.Services;

namespace WeatherWidget.Controllers
{
    [ApiController]
    [Route("controller")]
    public class WeatherController : Controller
    {
        private readonly ApiUsingService _service;
        public WeatherController(ApiUsingService service)
        {
            _service = service;
        }
        [HttpGet]
        public async Task<string> GetWeather(int longtitude,int latidute)
        {
            return await _service.GetApiContent(longtitude,latidute);
        }
    }
}
