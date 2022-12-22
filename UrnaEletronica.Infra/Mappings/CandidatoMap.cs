using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UrnaEletronica.Domains.Entities;
using UrnaEletronica.Domains.ValueObjects;
using static System.Net.Mime.MediaTypeNames;

namespace UrnaEletronica.Infra.Data.Mappings
{
    public class CandidatoMap : IEntityTypeConfiguration<Candidato> 
    {
        public void Configure(EntityTypeBuilder<Candidato> builder)
        {
            builder.HasKey(nome => nome.Id);
            builder.OwnsOne(candidato => candidato.Nome, nome =>
            {
                nome.Property(nome => nome.PrimeiroNome)
                .HasColumnName("PrimeiroNome")
                .HasColumnType("varchar(50)")
                ;
                nome.Property(nome => nome.Sobrenome)
                .HasColumnName("Sobrenome")
                .HasColumnType("varchar(50)")
                ;
                nome.Ignore(n => n.Notifications);

            });

            builder.OwnsOne(candidato => candidato.Partido, partido =>
            {
                partido.Property(partido => partido.Nome)
                .HasColumnName("Nome")
                .HasColumnType("varchar(50)");
                partido.Property(candidato => candidato.Sigla)
                .HasColumnType("Sigla")
                .HasColumnType("varchar(10)");
                partido.Property(candidato => candidato.DataCriacao)
                .HasColumnType("DataCriacao")
                .HasColumnType("date");
                partido.Ignore(p => p.Notifications);

            });

            builder.OwnsOne(candidato => candidato.Idade, idade =>
            {
                idade.Property(idade => idade.Numero)
                .HasColumnName("Idade")
                .HasColumnType("integer");
                idade.Ignore(i => i.Notifications);
            });

            builder.Ignore(c => c.Notifications);
        }
    }
}
