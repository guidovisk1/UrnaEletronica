using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UrnaEletronica.Domains.ValueObjects;
using UrnaEletronica.Shared.Entites;

namespace UrnaEletronica.Domains.Entities
{
   public sealed class Candidato : Entity
    {
        public Candidato(Nome nome, Idade idade, Partido partido)
        {
            Nome = nome;
            Idade = idade;
            Partido = partido;

            AddNotifications(Nome,Idade,Partido);
        }

        public Nome Nome { get; private set; }
        public Idade Idade { get; private set; }
        public Partido Partido { get; private set; }
    }
}
