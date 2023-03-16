using demo2.Models;
using Microsoft.AspNetCore.Mvc;


namespace demo2.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WeatherForecastController : ControllerBase {

        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger) {
            _logger = logger;
        }


        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherModels> Get() {
            return Enumerable.Range(1, 5).Select(index => new WeatherModels {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            }).ToArray();
        }
    }
}