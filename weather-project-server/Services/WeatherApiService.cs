using System.Net.Http;
using System.Text.Json;
using weather_project_server.Models;

namespace weather_project_server.Services
{
    public class WeatherApiService : IWeatherApiService
    {
        private readonly IHttpClientFactory _clientFactory;
        public WeatherApiService(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        public async Task<AstronomyModelResponse> GetAstronomyAsync(string cityName)
        {
            HttpClient httpClient = _clientFactory.CreateClient("WeatherApi");
            var response = await httpClient.GetAsync("/astronomy.json?q="+cityName);
            response.EnsureSuccessStatusCode();
            AstronomyModelResponse? body = await response.Content.ReadFromJsonAsync<AstronomyModelResponse>();
            

            if (body is null)
            {
                throw new NullReferenceException(nameof(body));
            }

            return body;
        }

        public async Task<RealTimeModelResponse> GetRealTimeAsync(string cityName)
        {
            HttpClient httpClient = _clientFactory.CreateClient("WeatherApi");
            var response = await httpClient.GetAsync("/current.json?q=" + cityName);
            response.EnsureSuccessStatusCode();
            RealTimeModelResponse? body = await response.Content.ReadFromJsonAsync<RealTimeModelResponse>();


            if (body is null)
            {
                throw new NullReferenceException(nameof(body));
            }

            return body;
        }

        public async Task<TimeZoneModelResponse> GetTimeZoneAsync(string cityName)
        {
            HttpClient httpClient = _clientFactory.CreateClient("WeatherApi");
            var response = await httpClient.GetAsync("/timezone.json?q=" + cityName);
            response.EnsureSuccessStatusCode();
            TimeZoneModelResponse? body = await response.Content.ReadFromJsonAsync<TimeZoneModelResponse>();


            if (body is null)
            {
                throw new NullReferenceException(nameof(body));
            }

            return body;
        }
    }
}
