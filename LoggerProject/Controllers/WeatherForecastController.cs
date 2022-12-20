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
            /*_logger.LogTrace("Logging Trace Message");
            _logger.LogDebug("Logging Debug Message");
            _logger.LogInformation("Logging Information Message");
            _logger.LogWarning("Logging Warning Message");
            _logger.LogError("Logging Error Message");*/
           // _logger.LogCritical("Logging Critical Message");

        }

        [HttpGet]
            [Route("WeatherForecast")]
            //[MySampleActionFilter("Action")]
            public IEnumerable<WeatherForecast> Get()
            {
            var iteracion = 1;

            _logger.LogDebug($"Debug {iteracion}");
            _logger.LogInformation($"Information {iteracion}");
            _logger.LogWarning($"Warning {iteracion}");
            _logger.LogError($"Error {iteracion}");
            _logger.LogCritical($"Critical {iteracion}");

            try
            {
                throw new NotImplementedException();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
            }

            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
             .ToArray();
        }

            /* public IActionResult About()
             {
                 _logger.LogInformation("Log message in the About() method");

                 return View();
             }*/
        }
    
}
