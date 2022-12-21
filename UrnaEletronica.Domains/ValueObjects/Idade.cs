using Flunt.Validations;
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
        public Idade(int numero)
        {
            Numero = numero;

            AddNotifications(new Contract<Idade>()
                .Requires()
                .IsGreaterOrEqualsThan(18,Numero, "Idade.Numero", "O eleitor deve ser maior de 18 anos")
                );
        }

        public int Numero { get; private set; }
       
    }
}
