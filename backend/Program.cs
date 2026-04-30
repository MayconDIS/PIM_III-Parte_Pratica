using Microsoft.EntityFrameworkCore;
using NexTI_API.Data;
using NexTI_API.Models;

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
builder.Services.AddDbContext<AppDbContext>(options =>
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

// --- USUÁRIOS ---
app.MapGet("/api/usuarios/{username}", async (string username, AppDbContext db) =>
{
    // SECURITY PATCH: Projetar (Select) apenas dados públicos do usuário para evitar vazamento do SenhaHash e Email
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

app.Run();
