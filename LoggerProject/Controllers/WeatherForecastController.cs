using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;

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


        }


        [HttpPost]
        [Route("WeatherForecast")]
        //[MySampleActionFilter("Action")]
        public string Loglevel(string msg, LogLevel logLevel)
        {
            if (logLevel == LogLevel.Debug)
            {
                _logger.LogDebug("Debug");
                return msg;
            }

            if (logLevel == LogLevel.Warning)
            {
                _logger.LogWarning($"Warning");
                return msg;
            }

            if (logLevel == LogLevel.Error)
            {
                _logger.LogError($"Error");
                return msg;
            }

            return msg;

        }

    }

           
        
    
}
