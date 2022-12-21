using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UrnaEletronica.Domains.Entities;
using UrnaEletronica.Infra.Data.Extensions;

namespace UrnaEletronica.Infra.Data.Context
{
    public class UrnaEletronicaContext : DbContext
    {
        #region DbSets
        public DbSet<Candidato> Candidatos => Set<Candidato>();
        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        
            modelBuilder.ConfigureMappings();
            modelBuilder.SeedData();

            base.OnModelCreating(modelBuilder);
        }
    }
}
