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
        public  Task<Stream> GetWeather(int longtitude,int latidute)
        {
            return  _service.GetApiContent(longtitude,latidute);
        }
    }
}
