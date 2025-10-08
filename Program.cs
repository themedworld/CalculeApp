using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

// Ajouter les services pour les controllers
builder.Services.AddControllers();

// Ajouter Swagger pour tester l'API facilement
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Activer Swagger seulement en mode développement
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Activer le routage des controllers
app.UseRouting();

// Permet d'autoriser les requêtes HTTP
app.UseAuthorization();

// Mapper les controllers
app.MapControllers();

// Démarrer l'application
app.Run();
