using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UrnaEletronica.Shared.ValueObjects;

namespace UrnaEletronica.Domains.ValueObjects
{
    public sealed class Idade : ValueObject
    {
        public Idade(int numero, DateOnly dataNascimento)
        {
            Numero = numero;
            DataNascimento = dataNascimento;
        }

        public int Numero { get; private set; }
        public DateOnly DataNascimento { get; private set; }
    }
}
