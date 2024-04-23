<script setup lang="ts">
import ResponseData from '../models/responsedata';

defineProps<{
    forecastInformation: ResponseData | null
}>()

</script>

<template>

    <div style="display:flex">
        <div class="weather-info">
            <h2>Location</h2>
            <p><strong>Name:</strong> {{ forecastInformation?.timeZoneModelResponse.location.name }}</p>
            <p><strong>Region:</strong> {{ forecastInformation?.timeZoneModelResponse.location.region }}</p>
            <p><strong>Country:</strong> {{ forecastInformation?.timeZoneModelResponse.location.country }}</p>
            <p><strong>Latitude:</strong> {{ forecastInformation?.timeZoneModelResponse.location.lat }}</p>
            <p><strong>Longitude:</strong> {{ forecastInformation?.timeZoneModelResponse.location.lon }}</p>
            <p><strong>Timezone:</strong> {{ forecastInformation?.timeZoneModelResponse.location.tz_id }}</p>
            <p><strong>Local Time:</strong> {{ forecastInformation?.timeZoneModelResponse.location.localtime }}</p>
        </div>

        <div class="weather-info">
            <h2>Current Weather</h2>
            <p><strong>Last Updated:</strong> {{ forecastInformation?.realTimeModelResponse.current.last_updated }}</p>
            <p><strong>Temperature (C):</strong> {{ forecastInformation?.realTimeModelResponse.current.temp_c }}</p>
            <p><strong>Temperature (F):</strong> {{ forecastInformation?.realTimeModelResponse.current.temp_f }}</p>
            <p><strong>Condition:</strong> {{ forecastInformation?.realTimeModelResponse.current.condition.text }}</p>
            <p><strong>Wind Speed (mph):</strong> {{ forecastInformation?.realTimeModelResponse.current.wind_mph }}</p>
            <p><strong>Wind Speed (kph):</strong> {{ forecastInformation?.realTimeModelResponse.current.wind_kph }}</p>
            <p><strong>Wind Direction:</strong> {{ forecastInformation?.realTimeModelResponse.current.wind_dir }}</p>
            <p><strong>Pressure (mb):</strong> {{ forecastInformation?.realTimeModelResponse.current.pressure_mb }}</p>
            <p><strong>Pressure (in):</strong> {{ forecastInformation?.realTimeModelResponse.current.pressure_in }}</p>
            <p><strong>Precipitation (mm):</strong> {{ forecastInformation?.realTimeModelResponse.current.precip_mm }}
            </p>
            <p><strong>Precipitation (in):</strong> {{ forecastInformation?.realTimeModelResponse.current.precip_in }}
            </p>
            <p><strong>Humidity:</strong> {{ forecastInformation?.realTimeModelResponse.current.humidity }}</p>
            <p><strong>Cloud:</strong> {{ forecastInformation?.realTimeModelResponse.current.cloud }}</p>
            <p><strong>Feels Like (C):</strong> {{ forecastInformation?.realTimeModelResponse.current.feelslike_c }}</p>
            <p><strong>Feels Like (F):</strong> {{ forecastInformation?.realTimeModelResponse.current.feelslike_f }}</p>
            <p><strong>Visibility (km):</strong> {{ forecastInformation?.realTimeModelResponse.current.vis_km }}</p>
            <p><strong>Visibility (miles):</strong> {{ forecastInformation?.realTimeModelResponse.current.vis_miles }}
            </p>
            <p><strong>UV:</strong> {{ forecastInformation?.realTimeModelResponse.current.uv }}</p>
            <p><strong>Gust (mph):</strong> {{ forecastInformation?.realTimeModelResponse.current.gust_mph }}</p>
            <p><strong>Gust (kph):</strong> {{ forecastInformation?.realTimeModelResponse.current.gust_kph }}</p>
        </div>

        <div class="weather-info">
            <h2>Astronomy</h2>
            <p><strong>Sunrise:</strong> {{ forecastInformation?.astronomyModelResponse.astronomy.astro.sunrise }}</p>
            <p><strong>Sunset:</strong> {{ forecastInformation?.astronomyModelResponse.astronomy.astro.sunset }}</p>
            <p><strong>Moonrise:</strong> {{ forecastInformation?.astronomyModelResponse.astronomy.astro.moonrise }}</p>
            <p><strong>Moonset:</strong> {{ forecastInformation?.astronomyModelResponse.astronomy.astro.moonset }}</p>
            <p><strong>Moon Phase:</strong> {{ forecastInformation?.astronomyModelResponse.astronomy.astro.moon_phase }}
            </p>
            <p><strong>Moon Illumination:</strong> {{
                forecastInformation?.astronomyModelResponse.astronomy.astro.moon_illumination }}</p>
            <p><strong>Is Moon Up:</strong> {{ forecastInformation?.astronomyModelResponse.astronomy.astro.is_moon_up ?
                'Yes' : 'No' }}</p>
            <p><strong>Is Sun Up:</strong> {{ forecastInformation?.astronomyModelResponse.astronomy.astro.is_sun_up ?
                'Yes'
                : 'No' }}</p>
        </div>
    </div>



</template>


<style scoped>
.weather-info {
    font-family: Arial, sans-serif;
    margin-left: 30px;
    text-align: left;
}

</style>