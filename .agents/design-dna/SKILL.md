---
name: design-dna
description: Apply the Design_DNA visual identity and design system to a project. When invoked, this skill automatically creates a Design_DNA folder in the user's workspace, saves the complete color palette, typography guidelines, and CSS structural foundations, enabling the replication of this dark, premium neon-glowing aesthetic.
---

# Design_DNA Skill

This skill is designed to automatically replicate the premium **Design_DNA** visual system in any web project. 

When this skill is invoked, you MUST execute the following actions to initialize the **Design_DNA** design tokens in the user's workspace.

## Execution Steps

### 1. Create the Directory
Create a directory named `Design_DNA` at the root of the project workspace.

### 2. Save the Color Palette (Design_DNA/paleta.json)
Create the file `Design_DNA/paleta.json` with the exact color system tokens:

```json
{
  "theme": "dark",
  "colors": {
    "background": {
      "main": "#0c0c0e",
      "card": "#1e1e24",
      "card_header": "#18181c"
    },
    "borders": {
      "default": "rgba(255, 255, 255, 0.05)",
      "accent_olive": "rgba(168, 184, 101, 0.25)"
    },
    "brand": {
      "olive_text": "#a8b865",
      "olive_bg": "#353822",
      "gold": "#c9b177",
      "gold_dim": "rgba(201, 177, 119, 0.6)",
      "cyan": "#00e6e6"
    },
    "glows": {
      "purple": "rgba(168, 85, 247, 0.15)",
      "cyan": "rgba(0, 230, 230, 0.11)"
    },
    "accents": {
      "success": "#a3e635",
      "success_dark": "#84cc16",
      "purple": "#a855f7",
      "purple_light": "#c084fc",
      "blue": "#3b82f6",
      "blue_light": "#60a5fa",
      "warning": "#f59e0b",
      "warning_light": "#fbbf24",
      "danger": "#f43f5e",
      "danger_light": "#fb7185",
      "muted": "#8c8c96",
      "dark_muted": "#585860"
    }
  },
  "typography": {
    "serif": "Lora, serif",
    "sans": "Inter, sans-serif",
    "mono": "Fira Code, monospace"
  }
}
```

### 3. Save the CSS Structural Code (Design_DNA/style.css)
Create the file `Design_DNA/style.css` containing the CSS Variables and background animations to serve as the project's visual base:

```css
/* ==========================================================================
   Design_DNA — Estilo Fiel às Imagens Modelo
   ========================================================================== */

:root {
    --bg-color: #0c0c0e;
    --card-bg: #1e1e24;
    --card-bg-header: #18181c;
    --border-color: rgba(255, 255, 255, 0.05);
    
    /* Cores Específicas do Modelo */
    --accent-olive-bg: #353822;
    --accent-olive-text: #a8b865;
    --accent-gold: #c9b177;
    --accent-gold-dim: rgba(201, 177, 119, 0.6);
    --link-cyan: #00e6e6;
    
    /* Glows */
    --glow-purple: rgba(168, 85, 247, 0.15);
    --glow-cyan: rgba(0, 230, 230, 0.11);
    
    /* Tipografia */
    --font-serif: 'Lora', serif;
    --font-sans: 'Inter', sans-serif;
    --font-mono: 'Fira Code', monospace;
    
    /* Textos */
    --text-main: #e8e8ec;
    --text-muted: #8c8c96;
    --text-dark: #585860;
}

/* Focos de luz radiais no fundo (Glows de exemplo) */
.radial-glow {
    position: fixed;
    width: 65vw;
    height: 65vw;
    border-radius: 50%;
    pointer-events: none;
    z-index: 0;
    filter: blur(140px);
    opacity: 0.55;
    transition: opacity 0.5s ease;
}

.glow-left {
    top: -25vh;
    left: -20vw;
    background: radial-gradient(circle, var(--glow-purple) 0%, rgba(0, 0, 0, 0) 70%);
    animation: floatGlowLeft 22s infinite alternate ease-in-out;
}

.glow-right {
    bottom: -25vh;
    right: -20vw;
    background: radial-gradient(circle, var(--glow-cyan) 0%, rgba(0, 0, 0, 0) 70%);
    animation: floatGlowRight 22s infinite alternate ease-in-out;
}

@keyframes floatGlowLeft {
    0% { transform: translate(0, 0) scale(1); }
    50% { transform: translate(5vw, 4vh) scale(1.12); }
    100% { transform: translate(0, 0) scale(1); }
}

@keyframes floatGlowRight {
    0% { transform: translate(0, 0) scale(1.12); }
    50% { transform: translate(-5vw, -4vh) scale(1); }
    100% { transform: translate(0, 0) scale(1.12); }
}

/* Cards do DNA */
.dna-card {
    background-color: var(--card-bg);
    border: 1px solid var(--border-color);
    border-radius: 12px;
    padding: 1.5rem;
    display: flex;
    flex-direction: column;
    position: relative;
    transition: transform 0.25s ease, border-color 0.25s ease;
}

/* Logo Card */
.logo-card {
    background-color: var(--card-bg);
    border-color: var(--border-color);
    display: flex;
    align-items: center;
    justify-content: center;
    cursor: pointer;
    min-height: 120px;
    overflow: hidden;
    padding: 1.2rem;
    transition: opacity 0.25s ease;
}

.logo-card:hover {
    opacity: 0.9;
}

.logo-image {
    max-width: 100%;
    max-height: 80px;
    object-fit: contain;
    border-radius: 8px;
}
```

### 4. Save the Guidelines (Design_DNA/diretrizes.md)
Create a quick readme and guidelines file inside `Design_DNA/diretrizes.md`:

```markdown
# Diretrizes do Design_DNA

Este diretório contém a especificação e tokens de design do **Design_DNA** para replicação fácil no projeto.

## Padrões Estéticos
* **Tema Escuro (Dark Mode):** O fundo principal deve utilizar a cor `#0c0c0e`.
* **Glows de Fundo:** Utilizar dois focos radiais animados, um roxo à esquerda e um ciano à direita, gerando atmosfera de profundidade.
* **Tipografia:** Mesclar a elegância clássica de itálicos serifados (`Lora`) em títulos com fontes limpas (`Inter`) e fontes técnicas monoespaçadas (`Fira Code`) para valores e códigos.
* **Logo Centralizado:** Imagens de marca e logo devem ser inseridas em contêineres com padding protetor e ajuste contido (`object-fit: contain`) para evitar cortes e distorções.
```

When you are done setting up these files, notify the user that the **Design_DNA** folder has been created and populated successfully in their project workspace.
