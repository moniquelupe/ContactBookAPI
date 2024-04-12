<template>
  <div>
    <h2>Detalhes do Contato</h2>
    <p><strong>Nome:</strong> {{ contact.name }}</p>
    <p><strong>E-mail:</strong> {{ contact.email }}</p>
    <p><strong>Telefone:</strong> {{ contact.phone }}</p>
  </div>
</template>

<script>
import api from '@/api/api'; // Importa o arquivo api.js para fazer chamadas à API

export default {
  data() {
    return {
      contact: {},
    };
  },
  async created() {
    try {
      const response = await api.get(`/contacts/${this.$route.params.id}`); // Faz a chamada para buscar os detalhes do contato com o ID fornecido na rota
      this.contact = response.data; // Atualiza o objeto de contato com os dados recebidos da API
    } catch (error) {
      console.error('Erro ao buscar detalhes do contato:', error);
    }
  },
};
</script>
