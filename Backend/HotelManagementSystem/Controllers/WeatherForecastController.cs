using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;


namespace HotelManagementSystem.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        // Your action methods here
    }
}
