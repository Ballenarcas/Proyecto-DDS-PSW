using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using DotNetEnv;

namespace Votify.Infrastructure.Persistence
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<VotifyDbContext>
    {
        public VotifyDbContext CreateDbContext(string[] args)
        {
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

            var host = Environment.GetEnvironmentVariable("DB_HOST");
            var port = Environment.GetEnvironmentVariable("DB_PORT");
            var db = Environment.GetEnvironmentVariable("DB_NAME");
            var user = Environment.GetEnvironmentVariable("DB_USER");
            var pass = Environment.GetEnvironmentVariable("DB_PASSWORD");
            

            var connectionString =
                $"Host={host};Port={port};Database={db};Username={user};Password={pass}";

            var optionsBuilder = new DbContextOptionsBuilder<VotifyDbContext>();
            optionsBuilder.UseNpgsql(connectionString);

            return new VotifyDbContext(optionsBuilder.Options);
        }
    }
}