using Microsoft.EntityFrameworkCore;
using NexTI_API.Data;
using NexTI_API.Models;

var builder = WebApplication.CreateBuilder(args);

// Configuração do CORS (Permitir acesso do Frontend local)
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowFrontend",
        policy => policy.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
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
    var user = await db.Usuarios.FirstOrDefaultAsync(u => u.Username == username);
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
