<div align="center">
  <img src=".Documentos_PIM_III/documents/assets/branding/Logo UNIP.png" alt="Logo UNIP" width="150" onerror="this.src='https://upload.wikimedia.org/wikipedia/commons/thumb/1/1d/UNIP_Logo.svg/1200px-UNIP_Logo.svg.png'"/>
  <h1>Nex_TI – EdTech Learning Platform</h1>
  <p><strong>Projeto Integrado Multidisciplinar (PIM III) - Análise e Desenvolvimento de Sistemas</strong></p>

  <!-- Badges -->
  <img src="https://img.shields.io/badge/HTML5-E34F26?style=for-the-badge&logo=html5&logoColor=white" />
  <img src="https://img.shields.io/badge/CSS3-1572B6?style=for-the-badge&logo=css3&logoColor=white" />
  <img src="https://img.shields.io/badge/JavaScript-F7DF1E?style=for-the-badge&logo=javascript&logoColor=black" />
  <img src="https://img.shields.io/badge/SQL_Server-CC2927?style=for-the-badge&logo=microsoft-sql-server&logoColor=white" />
</div>

<br>

*Read in: [English](#english-version) | [Português](#versao-em-portugues)*

---

## 🇧🇷 Versão em Português

### 📖 Sobre o Projeto
A **Nex_TI** é a implementação prática de uma plataforma web focada em avaliação e apoio à aprendizagem. O projeto foi desenvolvido para resolver a "curva de esquecimento" em treinamentos acadêmicos e corporativos.
Para isso, a plataforma integra:
- **Estudo Ativo & Repetição Espaçada:** Implementação algorítmica do SM-2 (Vanilla JavaScript) para calcular os intervalos ideais de revisão (Motor Anki).
- **Gamificação:** Distribuição de Pontos de Experiência (XP) e Moedas Virtuais com persistência em `localStorage`.
- **Acessibilidade Universal:** Foco total em semântica W3C, modo de alto contraste nativo e controles de zoom.

Este repositório abriga a **fase prática (MVP)** do sistema (PIM III), focando em uma arquitetura frontend modularizada e na estruturação do banco de dados relacional.

### 🚀 Tecnologias e Arquitetura

O projeto foi construído seguindo as melhores práticas de Clean Code e Separação de Responsabilidades (Separation of Concerns):

* **Frontend:** Desenvolvido em HTML5 semântico, responsivo via CSS Puro (Design System Global em `global.css`) e lógicas de negócios isoladas em módulos JavaScript puros (Vanilla JS), garantindo máxima performance sem dependências externas.
* **Backend Projetado:** A lógica de persistência atual funciona offline (`localStorage`), preparando o terreno para a API em `C# (.NET 10)` no semestre seguinte.
* **Banco de Dados:** SGBD `SQL Server` estruturado (`NexTI_DB.sql`) na pasta `database/`.

### 📂 Estrutura do Repositório

```text
📦 PIM_III-Parte_Pratica
 ┣ 📂 .planning/      # Inteligência do projeto, roadmap e arquitetura
 ┣ 📂 assets/         # Recursos globais e Design System
 ┃ ┣ 📂 css/          # global.css, splash.css
 ┃ ┗ 📂 js/           # auth.js, splash.js, data.js
 ┣ 📂 database/       # Script SQL do banco de dados (NexTI_DB.sql)
 ┣ 📂 pages/          # Telas e módulos do MVP
 ┃ ┣ 📂 dashboard/    # Interface principal, scripts do motor Anki e UI
 ┃ ┗ 📂 login/        # Tela de autenticação
 ┣ 📜 index.html      # Ponto de entrada / Splash Screen
 ┗ 📜 README.md       # Este documento
```

### 👥 Equipe de Desenvolvimento
Projeto acadêmico desenvolvido pelos alunos da UNIP - São José dos Campos (Turma 2026 / Diurno):
- **Gabriel Alves Moreira** (H67HJ4)
- **Maciel Costa da Silva** (R280985)
- **Maycon Douglas Inácio Silva** (H719CD3)
- **Miguel Angel Fernandez Ortiz** (H7858F9)
- **Rafael Mesquita** (H6722I0)

---

## 🇺🇸 English Version

### 📖 About the Project
**Nex_TI** is the practical implementation of a web-based assessment and learning support platform. The project was designed to solve the "forgetting curve" in academic and corporate training. 
To achieve this, the platform integrates:
- **Active Study & Spaced Repetition:** Algorithmic implementation of SM-2 (Vanilla JavaScript) to calculate optimal review intervals (Anki Engine).
- **Gamification:** Distribution of Experience Points (XP) and Virtual Coins with persistence in `localStorage`.
- **Universal Accessibility:** Strict adherence to W3C semantics, native high-contrast mode, and zoom controls.

This repository hosts the **practical phase (MVP)** of the system (PIM III), focusing on a modular frontend architecture and relational database structuring.

### 🚀 Technologies and Architecture

The project was built adhering to Clean Code and Separation of Concerns best practices:

* **Frontend:** Developed in semantic HTML5, responsive via Vanilla CSS (Global Design System in `global.css`), and business logic isolated in pure JavaScript modules (Vanilla JS), ensuring maximum performance with no external dependencies.
* **Planned Backend:** The current persistence logic works offline (`localStorage`), paving the way for the `C# (.NET 10)` API in the following semester.
* **Database:** `SQL Server` RDBMS structured (`NexTI_DB.sql`) in the `database/` folder.

### 📂 Repository Structure

```text
📦 PIM_III-Parte_Pratica
 ┣ 📂 .planning/      # Project intelligence, roadmap, and architecture
 ┣ 📂 assets/         # Global resources and Design System
 ┃ ┣ 📂 css/          # global.css, splash.css
 ┃ ┗ 📂 js/           # auth.js, splash.js, data.js
 ┣ 📂 database/       # Database SQL script (NexTI_DB.sql)
 ┣ 📂 pages/          # MVP screens and modules
 ┃ ┣ 📂 dashboard/    # Main interface, Anki engine scripts and UI
 ┃ ┗ 📂 login/        # Authentication screen
 ┣ 📜 index.html      # Entry point / Splash Screen
 ┗ 📜 README.md       # This file
```

### 👥 Development Team
Academic project developed by students from UNIP - São José dos Campos (Class of 2026 / Daytime):
- **Gabriel Alves Moreira** (H67HJ4)
- **Maciel Costa da Silva** (R280985)
- **Maycon Douglas Inácio Silva** (H719CD3)
- **Miguel Angel Fernandez Ortiz** (H7858F9)
- **Rafael Mesquita** (H6722I0)
