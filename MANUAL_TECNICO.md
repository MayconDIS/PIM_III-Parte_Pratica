# ⚙️ Manual Técnico e Arquitetural - Nex_TI

Este documento destina-se a desenvolvedores, mantenedores e professores da coordenação técnica. O Nex_TI foi concebido utilizando o padrão **Separation of Concerns (Separação de Preocupações)**, pronto para ser escalado como uma **Extensão Universitária** open-source.

---

## 🏗️ 1. Arquitetura do Sistema
A arquitetura segue o modelo de 3 Camadas (3-Tier):
- **Front-end:** SPA Vanilla (HTML5, CSS3, JavaScript ES6+).
- **Back-end:** API RESTful (C# 10, ASP.NET Core Web API Minimal APIs).
- **Database:** Microsoft SQL Server Relacional.

### 1.1 Diretórios Principais
- `/assets/`: Contém o **Design System Global** (CSS) e o serviço isolado de consumo de APIs (`api.js`).
- `/pages/`: Componentes visuais fragmentados (Login, Dashboard), semânticos e acessíveis.
- `/backend/`: Contém os Models, o `AppDbContext` do Entity Framework e a API C#.
- `/database/`: Guarda os scripts DDL (T-SQL) para replicação rápida em novos ambientes.

---

## 🔌 2. Integração via API (O Backend C#)
A aplicação .NET atua na porta HTTP padrão `5001`. A comunicação com a interface ocorre puramente via protocolo `HTTP (GET, POST)` retornando formato `JSON`.

**Endpoints Públicos:**
* `GET /api/status` - Health check.
* `GET /api/usuarios/{username}` - Autentica/recupera estado do player (Moedas, Nível, XP).
* `GET /api/fases` - Retorna mapeamento de módulos do banco.
* `GET /api/fases/{codigo}/flashcards` - Recupera as cartas interligadas pelo ForeignKey.

O **Entity Framework Core** foi empregado em abordagem *Code-First/Database-First* hibrida, eliminando a necessidade de redigir DataReaders (SQLClient) de forma bruta.

---

## ♿ 3. Padrões Web e Acessibilidade (Front-end)
Visando aprovação como projeto de extensão inclusivo, o Front-end cumpre especificações rigorosas:
- **WAI-ARIA:** Tags (`aria-label`, `aria-labelledby`, `role="main"`) mapeadas para leitores de tela em 100% da interface do Dashboard.
- **HTML5 Semântico:** Substituição de `<div>` randômicas por `<nav>`, `<section>`, `<article>` e `<main>`.
- **CSS Compartilhado:** Um único `global.css` garante que botões e fundos usem o mesmo Token de cor (ex: `--alura-cyan`).

---

## 🧠 4. O Algoritmo SM-2 (Banco de Dados)
A inteligência do projeto reside na tabela `Progresso_Flashcards`. 
Para adicionar suporte real ao Algoritmo de SuperMemo, o SQL e o C# monitoram:
- **IntervaloDias (Float):** Quanto tempo a carta deve sumir.
- **FatorFacilidade (Float >= 1.3):** Quão difícil a carta está para o aluno específico.
- **Repetições (Int):** Histórico de constância.

Para estender a aplicação no futuro, basta alterar a lógica nos *Controllers C#* para que os fatores sejam atualizados mediante um request `POST` quando o aluno clicar no botão de "Fácil" ou "Difícil" na tela.
