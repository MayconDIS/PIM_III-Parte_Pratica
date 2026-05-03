using Microsoft.EntityFrameworkCore;
using NexTI_API.Data;
using NexTI_API.Models;
using BCrypt.Net;

var builder = WebApplication.CreateBuilder(args);

// Configuração do CORS (Securizado: apenas portas do Live Server)
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowFrontend",
        policy => policy.WithOrigins("http://127.0.0.1:5500", "http://localhost:5500")
                        .AllowAnyMethod()
                        .AllowAnyHeader());
});

// Configuração do Entity Framework
builder.Services.AddDbContext<<AppAppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddOpenApi();

var app = builder.Build();

app.UseCors("AllowFrontend");

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

// ==========================================
// ENDPOINTS (ROTAS DA API)
// ==========================================

app.MapGet("/api/status", () => Results.Ok(new { message = "NexTI API está online e conectada!" }))
   .WithName("GetStatus");

// --- AUTENTICAÇÃO ---

app.MapPost("/api/auth/register", async (Usuario user, AppDbContext db) =>
{
    if (await db.Usuarios.AnyAsync(u => u.Username == user.Username)) 
        return Results.BadRequest(new { message = "Usuário já existe" });
    if (await db.Usuarios.AnyAsync(u => u.Email == user.Email)) 
        return Results.BadRequest(new { message = "Email já cadastrado" });

    user.SenhaHash = BCrypt.Net.BCrypt.HashPassword(user.SenhaHash);
    db.Usuarios.Add(user);
    await db.SaveChangesAsync();
    
    return Results.Ok(new { message = "Usuário criado com sucesso!", userId = user.Id });
});

app.MapPost("/api/auth/login", async (LoginRequest request, AppDbContext db) =>
{
    var user = await db.Usuarios.FirstOrDefaultAsync(u => u.Username == request.Username);
    if (user == null || !BCrypt.Net.BCrypt.Verify(request.Password, user.SenhaHash))
        return Results.Unauthorized();

    return Results.Ok(new { 
        id = user.Id, 
        username = user.Username, 
        nivel = user.Nivel, 
        xp = user.XP, 
        moedas = user.Moedas 
    });
});

// --- USUÁRIOS ---
app.MapGet("/api/usuarios/{username}", async (string username, AppDbContext db) =>
{
    var user = await db.Usuarios
        .Where(u => u.Username == username)
        .Select(u => new { u.Id, u.Username, u.Nivel, u.XP, u.Moedas })
        .FirstOrDefaultAsync();
        
    return user is not null ? Results.Ok(user) : Results.NotFound(new { message = "Usuário não encontrado" });
});

// --- FASES ---
app.MapGet("/api/fases", async (AppDbContext db) =>
{
    var fases = await db.Fases.ToListAsync();
    return Results.Ok(fases);
});

// --- FLASHCARDS ---
app.MapGet("/api/fases/{codigoFase}/flashcards", async (string codigoFase, AppDbContext db) =>
{
    var flashcards = await db.Flashcards.Where(f => f.CodigoFase == codigoFase).ToListAsync();
    return flashcards.Any() ? Results.Ok(flashcards) : Results.NotFound(new { message = "Nenhum flashcard encontrado para esta fase" });
});

// --- SM-2 PROGRESSO ---
app.MapPost("/api/progresso/atualizar", async (ProgressoUpdate request, AppDbContext db) =>
{
    var progresso = await db.Progresso_Flashcards.FindAsync(request.UsuarioId, request.FlashcardId);
    
    if (progresso == null)
    {
        progresso = new ProgressoFlashcard { 
            UsuarioId = request.UsuarioId, 
            FlashcardId = request.FlashcardId,
            FatorFacilidade = 2.5
        };
        db.Progresso_Flashcards.Add(progresso);
    }

    // Lógica SM-2 Simplificada
    int q = request.Qualidade; // 0 a 5
    if (q >= 3) {
        if (progresso.Repeticoes == 0) progresso.IntervaloDias = 1;
        else if (progresso.Repeticoes == 1) progrollo.IntervaloDias = 6;
        else progresso.IntervaloDias = progresso.IntervaloDias * progresso.FatorFacilidade;
        
        progresso.Repeticoes++;
        progresso.FatorFacilidade = progresso.FatorFacilidade + (0.1 - (5 - q) * (0.1));
    } else {
        progresso.Repeticoes = 0;
        progresso.IntervaloDias = 1;
        progresso.FatorFacilidade = Math.Max(1.3, progresso.FatorFacilidade - 0.2);
    }

    progresso.DataProximaRevisao = DateTime.UtcNow.Date.AddDays((int)progresso.IntervaloDias);
    await db.SaveChangesAsync();

    return Results.Ok(progresso);
});

app.Run();

// DTOs para requests
public record LoginRequest(string Username, string Password);
public record ProgressoUpdate(int UsuarioId, int FlashcardId, int Qualidade);

