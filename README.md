# Backend (ASP.NET Core)

A aplicação backend é construída utilizando **ASP.NET Core** e **Entity Framework Core**. Abaixo, temos a estrutura dos projetos principais:

- **Projeto API (Suz.Projetos.API)**: Este projeto é responsável por fornecer os endpoints RESTful, permitindo a interação com os dados da aplicação, como projetos, pessoas e categorias.
  
- **Projeto de Persistência (Suz.Projetos.Persistence)**: Contém a lógica de acesso ao banco de dados, incluindo o contexto do **Entity Framework Core** e os repositórios que interagem diretamente com as entidades.
  
- **Projeto de Domínio (Suz.Projetos.Domain)**: Este projeto é responsável pelas **entidades de domínio** e pelas interfaces para **repositories** e **services**, mantendo a lógica de negócios separada da infraestrutura e da API.

- **Migrações**: O **Entity Framework** é utilizado para criar as migrações e atualizar o banco de dados (**SQLite** neste caso), permitindo versionamento e controle das mudanças no esquema do banco.

## Endpoints da API

A API expõe os seguintes endpoints principais:

- **Adicionar Projeto** (`POST /api/projetos`): Cria um novo projeto, incluindo informações sobre título, descrição, data de criação, autor (pessoa) e categoria associada.

- **Listar Projetos** (`GET /api/projetos`): Recupera todos os projetos cadastrados na base de dados.

- **Filtrar Projetos** (`GET /api/projetos/filter`): Permite filtrar projetos com base em categoria e/ou subcategoria. 

---

# Tarefas do Desafio

Este desafio consiste em implementar funcionalidades essenciais no sistema, incluindo a criação de novas entidades, relacionamento entre elas e a adição de filtros para consulta. O objetivo é aprimorar a categorização dos projetos, permitindo uma busca mais detalhada por categorias e subcategorias.

## 1. **Branch `feature/add-categoria`**

### 1.1 **Adicionar Entidade Categoria/Subcategoria**
A primeira tarefa é criar as entidades **Categoria** e **Subcategoria**. Cada **Categoria** pode ter várias **Subcategorias**, estabelecendo um relacionamento de **um para muitos**. A **Subcategoria** deve estar vinculada a uma **Categoria** específica. Além disso, os dados dessas entidades devem ser persistidos no banco de dados.

### 1.2 **Adicionar Relacionamento com o Projeto**
Após a criação das entidades de **Categoria** e **Subcategoria**, o próximo passo é implementar o relacionamento entre a entidade **Projeto** e a **Categoria**. Cada **Projeto** deverá ter uma categoria associada através de uma chave estrangeira (**CategoriaId**). Além disso, a **Subcategoria** poderá ser vinculada a um projeto, permitindo um nível de categorização mais detalhado.

### 1.3 **Adicionar Filtro de Projetos por Categoria/Subcategoria**
Por fim, será necessário adicionar um filtro nos endpoints da API para permitir que os projetos sejam consultados com base na **Categoria** ou **Subcategoria**. Esse filtro pode ser implementado como parâmetros de consulta na API, permitindo que o usuário busque projetos específicos de acordo com suas necessidades de categorização.

## 2. **Revisar e Adicionar Comentários na Branch `feature/add-autor`**
Revise o código na branch `feature/add-autor`, faça melhorias e adicione comentários explicativos no código onde necessário. O objetivo é garantir que a implementação do relacionamento entre **Pessoa** e **Projeto** esteja correta e bem documentada.

## 3. **Fazer o Merge da Branch `feature/add-categoria` para a `main`**
Após completar a implementação da **Categoria**, **Subcategoria** e o filtro de projetos, faça o **merge** da branch `feature/add-categoria` para a `main` para consolidar as alterações no projeto principal.

## 4. **Criar um Projeto Next.js para Listar Pessoas e Projetos com Filtro por Categoria**
Desenvolver uma aplicação front-end simples utilizando Next.js, com foco nas funcionalidades. O objetivo é listar Pessoas e Projetos, sendo possível filtrar projetos por categoria. Não é necessário investir em um layout ou design; o foco deve ser exclusivamente na implementação correta das funcionalidades

## 5. **Com base em sua análise da aplicação, adicione abaixo sugestões de melhorias para a solução, caso tenha identificado algum ponto a ser aprimorado**

- 

---

# Comandos Auxiliares

Para garantir que o banco de dados esteja atualizado com as novas entidades e migrações, utilize os seguintes comandos do **Entity Framework**:

- **Adicionar migração**:
  ```bash
  dotnet ef migrations add NomeDaMigração --project ../Suz.Projetos.Persistence/
  dotnet ef database update --project ../Suz.Projetos.Persistence/
  