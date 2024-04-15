# ContactBookAPI

Este é um projeto de uma aplicação de agenda de contatos, com um backend desenvolvido em .NET 6 e um frontend Vue.js.

## Tecnologias utilizadas

- [.NET 6](https://dotnet.microsoft.com/download/dotnet/6.0)
- [Node.js](https://nodejs.org/)
- [Vue.js](https://vuejs.org/)
- [Vue CLI](https://cli.vuejs.org/)
- [SQLite](https://www.sqlite.org/index.html)

## Funcionalidades

- CRUD de contatos (nome, email e telefone)
- Documentação da API com Swagger
- Interação com o banco de dados SQLite através do Entity Framework
- Validação de dados de entrada

## Configuração

```bash
# Clonar o repositório:
git clone https://github.com/moniquelupe/ContactBookAPI.git

# Instalar dependências do backend:
cd ContactBookAPI
dotnet restore

# Instalar dependências do frontend:
cd clientapp
npm install

# Backend:
dotnet run

# Frontend:
cd clientapp
npm run serve

# Acessar a aplicação:

Backend: http://localhost:5054
Frontend: http://localhost:8080

