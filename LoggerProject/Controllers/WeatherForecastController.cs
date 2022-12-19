using Microsoft.AspNetCore.Mvc;

namespace LoggerProject.Controllers
{
    
        [ApiController]
        [Route("api/[controller]")]
        //[MySampleActionFilter("Weather")]
        public class WeatherForecastController : ControllerBase

        {
            private static readonly string[] Summaries = new[]
            {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
            };

            private readonly ILogger<WeatherForecastController> _logger;

            public WeatherForecastController(ILogger<WeatherForecastController> logger)
            {
                _logger = logger;
            _logger.LogTrace("Logging Trace Message");
            _logger.LogDebug("Logging Debug Message");
            _logger.LogInformation("Logging Information Message");
            _logger.LogWarning("Logging Warning Message");
            _logger.LogError("Logging Error Message");
           // _logger.LogCritical("Logging Critical Message");

        }

        [HttpGet]
            [Route("WeatherForecast")]
            //[MySampleActionFilter("Action")]
            public string Get()
            {
                var rng = new Random();


                //Date = DateTime.Now.AddDays();
                /*int TemperatureC = rng.Next(-20, 55);
                return TemperatureC;*/
                string Summary = Summaries[rng.Next(Summaries.Length)];
                return Summary;
                //}).ToArray();
            }

            /* public IActionResult About()
             {
                 _logger.LogInformation("Log message in the About() method");

                 return View();
             }*/
        }
    
}
