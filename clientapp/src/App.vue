<template>
  <div id="app">
    <img alt="Blue logo" src="./assets/logo.png">
    <ContactList msg="Teste técnico desenvolvido por Monique Lupe"/>
  </div>
</template>

<script>
import Vue from 'vue'
import ContactList from './components/ContactList.vue'

Vue.config.productionTip = false

export default {
  name: 'App',
  components: {
    ContactList
  }
}
</script>

<style>
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  text-align: center;
  color: #2c3e50;
  margin-top: 60px;
}
</style>
