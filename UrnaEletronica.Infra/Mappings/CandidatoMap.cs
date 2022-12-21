using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UrnaEletronica.Domains.Entities;

namespace UrnaEletronica.Infra.Data.Mappings
{
    public class CandidatoMap : IEntityTypeConfiguration<Candidato> 
    {
        public void Configure(EntityTypeBuilder<Candidato> builder)
        {
            builder.HasKey(nome => nome.Id);
            builder.OwnsOne(candidato => candidato.Nome, nome =>
            {
                nome.Property(nome => nome.PrimeiroNome);
            });
        }
    }
}
