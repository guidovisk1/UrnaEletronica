using Microsoft.EntityFrameworkCore;
using UrnaEletronica.Domains.Entities;
using UrnaEletronica.Infra.Data.Extensions;

namespace UrnaEletronica.Infra.Data.Context
{
    public class UrnaEletronicaContext : DbContext
    {
        private const string CONNECTION_STRING = "User ID=postgres;Password=123;Host=localhost;Port=5432;Database=UrnaEletronica;";

        #region DbSets
        public DbSet<Candidato> Candidatos => Set<Candidato>();
        #endregion

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder
            .UseNpgsql(CONNECTION_STRING)
            .EnableSensitiveDataLogging();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ConfigureMappings();

            base.OnModelCreating(modelBuilder);
        }

    }
}
