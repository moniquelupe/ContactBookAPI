<template>
  <div>
    <h2>Lista de Contatos</h2>
    <ul>
      <li v-for="contact in contacts" :key="contact.id">
        {{ contact.name }} - {{ contact.email }} - {{ contact.phone }}
      </li>
    </ul>
  </div>
</template>

<script>
import api from '../../../clientapp/src/api/api'; // Importa o arquivo api.js para fazer chamadas à API 

export default {
  data() {
    return {
      contacts: [],
    };
  },
  async created() {
    try {
      const response = await api.get('/contacts'); // Faz a chamada para buscar os contatos
      this.contacts = response.data; // Atualiza a lista de contatos com os dados recebidos da API
    } catch (error) {
      console.error('Erro ao buscar contatos:', error);
    }
  },
};
</script>

<style>
</style>
