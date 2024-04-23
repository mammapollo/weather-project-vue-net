import httpclient from "../http-client";

class WeatherForecastDataService {
  getWeatherInfo(city: string | null): Promise<any> {
    return httpclient.get(`/api/weather?cityName=${city}`);
  }

}

export default new WeatherForecastDataService();