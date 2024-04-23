using weather_project_server.Models;

namespace weather_project_server.Services
{
    public interface IWeatherApiService
    {

        public Task<TimeZoneModelResponse> GetTimeZoneAsync(string cityName);
        public Task<RealTimeModelResponse> GetRealTimeAsync(string cityName);
        public Task<AstronomyModelResponse> GetAstronomyAsync(string cityName);

    }
}
