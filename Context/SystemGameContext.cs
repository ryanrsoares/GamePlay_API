using Microsoft.EntityFrameworkCore;
using SystemGameAPI.Domains;

namespace SystemGameAPI.Context
{
    public class SystemGameContext : DbContext
    {
        public SystemGameContext()
        {
        }
        public SystemGameContext(DbContextOptions<SystemGameContext> options)
            : base(options)
        {
        }

        public DbSet<Jogos> Jogos { get; set; }

        public DbSet<Usuarios> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=NOTE26-S28\\SQLEXPRESS; Database=SistemaDeGameAPI; User id=sa; Pwd=Senai@134; TrustServerCertificate=true;");
            }
        }
    }
}
