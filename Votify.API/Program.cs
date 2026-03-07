using DotNetEnv;
using Votify.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Votify.Application.Interface;
using Votify.Application.Services;

static string? FindEnvFile()
{
    foreach (var startDir in new[] { Directory.GetCurrentDirectory(), AppContext.BaseDirectory })
    {
        var dir = startDir;
        while (dir != null)
        {
            var candidate = Path.Combine(dir, ".env");
            if (File.Exists(candidate)) return candidate;
            dir = Directory.GetParent(dir)?.FullName;
        }
    }
    return null;
}

var envFile = FindEnvFile();
if (envFile != null) Env.Load(envFile);

var builder = WebApplication.CreateBuilder(args);

var host = Environment.GetEnvironmentVariable("DB_HOST");
var db = Environment.GetEnvironmentVariable("DB_NAME");
var user = Environment.GetEnvironmentVariable("DB_USER");
var pass = Environment.GetEnvironmentVariable("DB_PASSWORD");
var port = Environment.GetEnvironmentVariable("DB_PORT");

var connectionString =
    $"Host={host};Port={port};Database={db};Username={user};Password={pass};SslMode=Require;Trust Server Certificate=true;";

builder.Services.AddDbContext<VotifyDbContext>(options =>
    options.UseNpgsql(connectionString));

builder.Services.AddScoped<IVotacionService, VotacionService>();

builder.Services.AddControllers();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowBlazor",
        policy =>
        {
            policy.AllowAnyOrigin()
                  .AllowAnyMethod()
                  .AllowAnyHeader();
        });
});

var app = builder.Build();

app.UseCors("AllowBlazor");

app.UseHttpsRedirection();

app.MapControllers();

app.Run();