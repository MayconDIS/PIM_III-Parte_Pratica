// ==========================================
// SERVIÇO DE INTEGRAÇÃO COM A API (FETCH)
// ==========================================

const API_BASE_URL = 'https://localhost:5001/api';

const ApiService = {
    // 1. Verifica se a API está online
    checkStatus: async () => {
        try {
            const response = await fetch(`${API_BASE_URL}/status`);
            return response.ok;
        } catch (error) {
            console.error("Erro ao conectar com a API:", error);
            return false;
        }
    },

    // 2. Busca o Usuário no Banco de Dados
    getUsuario: async (username) => {
        try {
            const response = await fetch(`${API_BASE_URL}/usuarios/${username}`);
            if (!response.ok) throw new Error("Usuário não encontrado");
            return await response.json();
        } catch (error) {
            console.error(error);
            return null;
        }
    },

    // 3. Busca todas as Fases cadastradas
    getFases: async () => {
        try {
            const response = await fetch(`${API_BASE_URL}/fases`);
            return await response.json();
        } catch (error) {
            console.error("Erro ao buscar fases:", error);
            return [];
        }
    },

    // 4. Busca os Flashcards de uma Fase específica
    getFlashcardsPorFase: async (codigoFase) => {
        try {
            const response = await fetch(`${API_BASE_URL}/fases/${codigoFase}/flashcards`);
            if (!response.ok) throw new Error("Flashcards não encontrados");
            return await response.json();
        } catch (error) {
            console.error(error);
            return [];
        }
    }
};

// Exportar globalmente para ser usado no dashboard e login
window.ApiService = ApiService;
