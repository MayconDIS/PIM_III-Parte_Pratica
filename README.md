<div align="center">
  <img src="assets/img/Logo%20UNIP.png" alt="Logo UNIP" width="150" onerror="this.src='https://upload.wikimedia.org/wikipedia/commons/thumb/1/1d/UNIP_Logo.svg/1200px-UNIP_Logo.svg.png'"/>
  <h1>Nex_TI – EdTech Learning Platform</h1>
  <p><strong>Projeto Integrado Multidisciplinar (PIM III) - Análise e Desenvolvimento de Sistemas</strong></p>

  <!-- Badges -->
  <img src="https://img.shields.io/badge/HTML5-E34F26?style=for-the-badge&logo=html5&logoColor=white" />
  <img src="https://img.shields.io/badge/CSS3-1572B6?style=for-the-badge&logo=css3&logoColor=white" />
  <img src="https://img.shields.io/badge/JavaScript-F7DF1E?style=for-the-badge&logo=javascript&logoColor=black" />
  <img src="https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white" />
  <img src="https://img.shields.io/badge/.NET_10-512BD4?style=for-the-badge&logo=dotnet&logoColor=white" />
  <img src="https://img.shields.io/badge/SQL_Server-CC2927?style=for-the-badge&logo=microsoft-sql-server&logoColor=white" />
</div>

<br>

*Read in: [English](#english-version) | [Português](#versao-em-portugues)*

---

## 🇧🇷 Versão em Português

### 📖 Sobre o Projeto
A **Nex_TI** é a implementação prática de uma plataforma web focada em avaliação e apoio à aprendizagem. O projeto foi desenvolvido para resolver a "curva de esquecimento" em treinamentos acadêmicos e corporativos.
Para isso, a plataforma integra:
- **Estudo Ativo & Repetição Espaçada:** Implementação algorítmica do SM-2 para calcular os intervalos ideais de revisão (Motor Anki).
- **Gamificação:** Distribuição de Pontos de Experiência (XP) e Moedas Virtuais com níveis de progressão.
- **Acessibilidade Universal:** Foco total em semântica W3C, modo de alto contraste nativo e controles de zoom.
- **Mapa Neural (Obsidian View):** Visualização interativa do progresso acadêmico com física de molas, drag-and-drop e persistência de estado.

Este repositório abriga o sistema Fullstack completo (PIM III), focado em uma arquitetura limpa (Separation of Concerns), integrando Frontend, API RESTful e Banco de Dados Relacional.

### 🚀 Tecnologias e Arquitetura

O projeto foi construído seguindo as melhores práticas do mercado:

* **Frontend:** Desenvolvido em HTML5 semântico, responsivo via CSS Puro (Design System Global) e lógicas isoladas em Vanilla JS, consumindo a API via `fetch`.
* **Backend:** API RESTful desenvolvida em `C# (.NET 10)` utilizando **Minimal APIs** e **Entity Framework Core**, com políticas de CORS e mitigação de vulnerabilidades (OWASP).
* **Banco de Dados:** SGBD `SQL Server` estruturado (`NexTI_DB.sql`) garantindo restrições de gamificação no nível do banco.

### 📂 Estrutura do Repositório

```text
📦 PIM_III-Parte_Pratica
 ┣ 📂 .planning/      # Inteligência do projeto, roadmap e arquitetura
 ┣ 📂 assets/         # Recursos globais e Design System
 ┃ ┣ 📂 css/          # global.css, splash.css
 ┃ ┗ 📂 js/           # api.js, auth.js, splash.js
 ┣ 📂 backend/        # API C# .NET 10 (Controllers, Models, DbContext)
 ┣ 📂 database/       # Script SQL do banco de dados (NexTI_DB.sql)
 ┣ 📂 pages/          # Telas e módulos do Frontend
 ┃ ┣ 📂 dashboard/    # Interface principal, Motor SM-2 e Mapa Neural
 ┃ ┣ 📂 login/        # Autenticação do usuário
 ┃ ┗ 📂 sobre/        # Página informativa da plataforma
 ┣ 📜 index.html      # Ponto de entrada / Splash Screen
 ┣ 📜 MANUAL_DE_EXECUCAO.md  # Guia para a banca rodar o projeto
 ┣ 📜 MANUAL_PRATICO.md      # Guia do Usuário final (Extensão Universitária)
 ┗ 📜 MANUAL_TECNICO.md      # Guia de Arquitetura e Engenharia de Software
```

### 👥 Equipe de Desenvolvimento
Projeto acadêmico desenvolvido pelos alunos da UNIP - São José dos Campos (Turma 2026 / Diurno):
- **Gabriel Alves Moreira** (H67HJI4)
- **Maciel Costa da Silva** (R280985)
- **Maycon Douglas Inácio Silva** (H719CD3)
- **Miguel Angel Fernandez Ortiz** (H7858F9)
- **Rafael Mesquita** (H6722I0)

---

## 🇺🇸 English Version

### 📖 About the Project
**Nex_TI** is the practical implementation of a web-based assessment and learning support platform. The project was designed to solve the "forgetting curve" in academic and corporate training. 
To achieve this, the platform integrates:
- **Active Study & Spaced Repetition:** Algorithmic implementation of SM-2 to calculate optimal review intervals (Anki Engine).
- **Gamification:** Distribution of Experience Points (XP) and Virtual Coins with progression levels.
- **Universal Accessibility:** Strict adherence to W3C semantics, native high-contrast mode, and zoom controls.
- **Neural Map (Obsidian View):** Interactive academic progress visualization with spring physics, drag-and-drop, and state persistence.

This repository hosts the complete Fullstack system (PIM III), focused on a clean architecture (Separation of Concerns), integrating Frontend, RESTful API, and Relational Database.

### 🚀 Technologies and Architecture

The project was built adhering to industry best practices:

* **Frontend:** Developed in semantic HTML5, responsive via Vanilla CSS (Global Design System), and business logic isolated in Vanilla JS, consuming the API via `fetch`.
* **Backend:** RESTful API developed in `C# (.NET 10)` using **Minimal APIs** and **Entity Framework Core**, including CORS policies and vulnerability mitigations (OWASP).
* **Database:** `SQL Server` RDBMS structured (`NexTI_DB.sql`) ensuring gamification constraints at the database level.

### 📂 Repository Structure

```text
📦 PIM_III-Parte_Pratica
 ┣ 📂 .planning/      # Project intelligence, roadmap, and architecture
 ┣ 📂 assets/         # Global resources and Design System
 ┃ ┣ 📂 css/          # global.css, splash.css
 ┃ ┗ 📂 js/           # api.js, auth.js, splash.js
 ┣ 📂 backend/        # C# .NET 10 API (Controllers, Models, DbContext)
 ┣ 📂 database/       # Database SQL script (NexTI_DB.sql)
 ┣ 📂 pages/          # Frontend screens and modules
 ┃ ┣ 📂 dashboard/    # Main interface, SM-2 Engine, and Neural Map
 ┃ ┣ 📂 login/        # User authentication
 ┃ ┗ 📂 sobre/        # Platform informational page
 ┣ 📜 index.html      # Entry point / Splash Screen
 ┣ 📜 MANUAL_DE_EXECUCAO.md  # Guide for evaluators to run the project
 ┣ 📜 MANUAL_PRATICO.md      # End-User Guide (University Extension)
 ┗ 📜 MANUAL_TECNICO.md      # Architecture and Software Engineering Guide
```

### 👥 Development Team
Academic project developed by students from UNIP - São José dos Campos (Class of 2026 / Daytime):
- **Gabriel Alves Moreira** (H67HJI4)
- **Maciel Costa da Silva** (R280985)
- **Maycon Douglas Inácio Silva** (H719CD3)
- **Miguel Angel Fernandez Ortiz** (H7858F9)
- **Rafael Mesquita** (H6722I0)
