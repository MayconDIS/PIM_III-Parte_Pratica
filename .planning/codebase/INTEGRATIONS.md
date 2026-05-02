---
mapped_date: "2026-05-02"
---
*Read in: [English](#english-version) | [Português](#versao-em-portugues)*

---
## English Version

# Integrations

### Internal Systems
- **SM-2 Algorithm**: Spaced repetition engine implemented in the frontend (`app.js`) with full interval calculation, ease factors, and LocalStorage persistence. Backend integration planned for future phases.
- **Neural Map Engine**: Graph visualization module (`neural-map.js`) consuming global state (`meusDecks`, `srsData`, `fasesDesbloqueadas`) from `app.js` and persisting camera/node positions via LocalStorage.

### External Services
- No external APIs are actively integrated in the current codebase. The documentation mentions future integration with AI models for generating flashcard summaries.

---
## Versão em Português

# Integrações

### Sistemas Internos
- **Algoritmo SM-2**: Motor de repetição espaçada implementado no frontend (`app.js`) com cálculo completo de intervalos, fatores de facilidade e persistência via LocalStorage. Integração com backend planejada para fases futuras.
- **Motor do Mapa Neural**: Módulo de visualização de grafos (`neural-map.js`) que consome o estado global (`meusDecks`, `srsData`, `fasesDesbloqueadas`) do `app.js` e persiste posições de câmera/nós via LocalStorage.

### Serviços Externos
- Nenhuma API externa está ativamente integrada na base de código atual. A documentação menciona uma integração futura com modelos de IA para geração de resumos de flashcards.
