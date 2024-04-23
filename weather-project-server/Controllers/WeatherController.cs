using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using weather_project_server.Models;
using weather_project_server.Services;

namespace weather_project_server.Controllers
{
    [ApiController]
    [Route("api/weather")]
    [EnableCors("_myAllowSpecificOrigins")]
    public class WeatherController : ControllerBase
    {
        private readonly ILogger<WeatherController> _logger;
        private readonly IWeatherApiService _weatherApiService;


        public WeatherController(IWeatherApiService weatherApiService, ILogger<WeatherController> logger)
        {
            _logger = logger;
            _weatherApiService = weatherApiService;
        }

        [HttpGet]
        public async Task<IActionResult> Get(string cityName)
        {

            if (string.IsNullOrEmpty(cityName))
            {
                return BadRequest("No city provided");
            }

            try
            {
                var astronomyModelResponse = await _weatherApiService.GetAstronomyAsync(cityName);
                var realTimeModelResponse = await _weatherApiService.GetRealTimeAsync(cityName);
                var timeZoneModelResponse = await _weatherApiService.GetTimeZoneAsync(cityName);

                return Ok(new { astronomyModelResponse, realTimeModelResponse, timeZoneModelResponse });
            }
            catch (HttpRequestException ex)
            {
                _logger.LogError(ex.Message, ex);
                return BadRequest("Http request exception");
            }
            catch (NullReferenceException ex)
            {
                _logger.LogError(ex.Message, ex);
                return BadRequest("No information provided");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message, ex);
                return BadRequest("Unmanaged exception");
            }

        }
    }
}
