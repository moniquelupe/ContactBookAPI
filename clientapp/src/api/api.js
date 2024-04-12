import axios from 'axios';

const baseURL = 'http://localhost:5054/api/contacts';

const api = axios.create({
  baseURL: baseURL,
  headers: {
    'Content-Type': 'application/json',
  },
});

export default api;

