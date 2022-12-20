using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.VisualBasic;

namespace LoggerProject.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    //[MySampleActionFilter("Weather")]
    public class WeatherForecastController : ControllerBase

    {
       

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
          
            _logger.Log(logLevel, $" This message is {logLevel}");

            if (_logger.IsEnabled(logLevel))
            {

                //  _logger.Log(logLevel, $" This message is {logLevel}");
                Console.WriteLine( $"current loglevel is {logLevel} and log is printed");
               
            }
            else
              

               Console.WriteLine($"current loglevel is {logLevel} and log is not printed");
            return msg;
            

        }

    }

           
        
    
}
