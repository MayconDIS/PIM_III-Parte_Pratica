---
mapped_date: "2026-04-30"
---
*Read in: [English](#english-version) | [Português](#versao-em-portugues)*

---
## English Version

# Architecture

### Design Patterns
- **Object-Oriented Programming (OOP)**: The C# backend is modeled with inheritance (e.g., `Admin`, `Tutor`, `Aluno` deriving from `Usuario`) and composition (e.g., `Aluno` has `XP`, `Moedas`, `Simulado`).
- **Relational Database**: Modeled via Entity-Relationship Diagram with SQL Server.

### Data Flow
- Users interact via the responsive web interface (Vanilla JS/HTML5).
- The Frontend `api.js` service performs HTTP GET/POST requests using the `Fetch API`.
- The Backend (C# .NET 10 Minimal APIs) processes requests, interacting with the SQL Server via Entity Framework Core.
- Data (XP, Flashcards, Progress) is retrieved, updated, and returned to the UI as JSON.

---
## Versão em Português

# Arquitetura

### Padrões de Projeto (Design Patterns)
- **Programação Orientada a Objetos (POO)**: O backend em C# é modelado com herança (ex: `Admin`, `Tutor`, `Aluno` derivando de `Usuario`) e composição (ex: `Aluno` possui `XP`, `Moedas`, `Simulado`).
- **Banco de Dados Relacional**: Modelado via Diagrama Entidade-Relacionamento (DER) para SQL Server.

### Fluxo de Dados
- Os usuários interagem através da interface web responsiva (Vanilla JS/HTML5).
- O serviço `api.js` do Frontend realiza requisições HTTP GET/POST usando a `Fetch API`.
- O Backend (C# .NET 10 Minimal APIs) processa as requisições e interage com o SQL Server via Entity Framework Core.
- Os dados (XP, Flashcards, Progresso) são recuperados, atualizados e retornados para a UI em formato JSON.
