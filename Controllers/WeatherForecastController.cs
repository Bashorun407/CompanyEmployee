using Contracts;
using Microsoft.AspNetCore.Mvc;

namespace CompanyEmployee.Controllers
{
    //THE PRESENTATION LAYER IS NOW USED AS THE CONTROLLER CLASS INSTEAD OF THIS ONE

    /*   [ApiController]
       [Route("[controller]")]
       public class WeatherForecastController : ControllerBase
       {
           *//* private static readonly string[] Summaries = new[]
            {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

            private readonly ILogger<WeatherForecastController> _logger;

            public WeatherForecastController(ILogger<WeatherForecastController> logger)
            {
                _logger = logger;
            }

            [HttpGet(Name = "GetWeatherForecast")]
            public IEnumerable<WeatherForecast> Get()
            {
                return Enumerable.Range(1, 5).Select(index => new WeatherForecast
                {
                    Date = DateTime.Now.AddDays(index),
                    TemperatureC = Random.Shared.Next(-20, 55),
                    Summary = Summaries[Random.Shared.Next(Summaries.Length)]
                })
                .ToArray();
            }*//*

           private ILoggerManager _logger;

           public WeatherForecastController(ILoggerManager logger)
           {
               _logger = logger;
           }

           [HttpGet]
           public IEnumerable<string> Get()
           {
               _logger.LogInfo("Here's info message from our value controller");
               _logger.LogDebug("Here's debug message from our value controller");
               _logger.LogWarning("Here's warn message from our value controller");
               _logger.LogError("Here's error message from our value controller");

               return new string[] { "value1", "value2" };
           }
       }*/
}