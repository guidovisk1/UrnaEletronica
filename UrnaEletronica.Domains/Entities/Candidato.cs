using Flunt.Validations;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UrnaEletronica.Domains.Enums;
using UrnaEletronica.Domains.ValueObjects;
using UrnaEletronica.Shared.Entites;

namespace UrnaEletronica.Domains.Entities
{
   public sealed class Candidato : Entity
    {
        private Candidato() // For EF core 
        {
        }

        public Candidato(Nome nome, Idade idade, Partido partido, string numeroVoto,
            ECargo cargo)
        {
            Nome = nome;
            Idade = idade;
            Partido = partido;
            NumeroVoto = numeroVoto;
            Cargo = cargo;

            AddNotifications(Nome, Idade, Partido);
            AddNotifications(new Contract<Candidato>()
                .Requires()
                .IsTrue(ValidarVoto(), "Candidato", "Voto inválido")
                );
        }

        public Nome Nome { get; private set; }
        public Idade Idade { get; private set; }
        public Partido Partido { get; private set; }
        public string NumeroVoto { get; private set; }
        public ECargo Cargo { get; private set; }

        private bool ValidarVoto()
        {
            if(Cargo == ECargo.Presidente 
                && NumeroVoto.Length == 2)
                return true;

            if (Cargo == ECargo.Senador
                 && NumeroVoto.Length == 3)
                return true;

            return false;
        }
    }
}
