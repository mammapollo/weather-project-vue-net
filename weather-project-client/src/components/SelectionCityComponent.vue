<script setup lang="ts">
import WeatherForecastDataService from '../services/WeatherForecastDataService';
import { AxiosResponse } from 'axios';
import ResponseData from '../models/responsedata';
import InformationPanel from './InformationPanel.vue';
import { ref } from 'vue';

defineProps<{ msg: string }>()

function handleCitySelection(cityName: string): void {
  isLoading.value = true;
  WeatherForecastDataService.getWeatherInfo(cityName)
    .then((response: AxiosResponse<ResponseData>) => {
      console.log('astronomy:' + response.data.astronomyModelResponse);
      console.log('realtime:' + response.data.realTimeModelResponse);
      console.log('timezone:' + response.data.timeZoneModelResponse);
      forecastInformation.value = response.data;
      isLoading.value = false;
      isLoaded.value = true;
      errorMessage.value = false;
      scrollToElement();
    })
    .catch(() => {
      errorMessage.value = true;
    });
}

function scrollToElement() {
  const element = document.getElementById("belowpanel");

  if(element){
    element.scrollIntoView({ behavior: "smooth", block: "start"});
  }

}

const forecastInformation = ref<ResponseData | null>(null);
const isLoading = ref<boolean>(false);
const isLoaded = ref<boolean>(false);
const errorMessage = ref<boolean>(false);

</script>

<template>
  <h1>{{ msg }}</h1>
  <h1 style="color: red;" v-if="errorMessage">An error occurred, contact customer service</h1>

  <div class="card">
    <button class="citybutton" type="button" @click="handleCitySelection('Dublin')">Dublin</button>
    <button class="citybutton" type="button" @click="handleCitySelection('London')">London</button>
    <button class="citybutton" type="button" @click="handleCitySelection('Tokyo')">Tokyo</button>
  </div>

  <p class="read-the-docs">Click on the city for which you want to know the weather forecast</p>

  <div id="belowpanel" class="contentpanel">
    <div v-if="isLoading">
      <img src="../assets/loading.gif" />
    </div>
    <div v-if="isLoaded">
      <InformationPanel :forecastInformation="forecastInformation"></InformationPanel>
    </div>
  </div>


</template>

<style scoped>
.read-the-docs {
  color: #888;
}

.logo {
  height: 6em;
  padding: 1.5em;
  will-change: filter;
  transition: filter 300ms;
}

.citybutton {
  margin-left: 10px;
}

</style>
