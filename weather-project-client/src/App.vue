<script setup lang="ts">
import SelectionCityComponent from './components/SelectionCityComponent.vue';
</script>

<template>
  <div>
    <a>
      <img src="./assets/sun.png" class="logo" />
    </a>
    <a>
      <img src="./assets/cloud-sun.png" class="logo" />
    </a>
  </div>
  <SelectionCityComponent msg="Weather Forecast" />
</template>

<style scoped>
.logo {
  height: 6em;
  padding: 1.5em;
  will-change: filter;
  transition: filter 300ms;
}
.logo:hover {
  filter: drop-shadow(0 0 2em #646cffaa);
}
.logo.vue:hover {
  filter: drop-shadow(0 0 2em #42b883aa);
}
</style>
