using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flunt.Notifications;
using Flunt.Validations;
using UrnaEletronica.Shared.ValueObjects;

namespace UrnaEletronica.Domains.ValueObjects
{
    public sealed class Nome : ValueObject
    {
        public Nome(string primeiroNome, string sobrenome)
        {
            PrimeiroNome = primeiroNome;
            Sobrenome = sobrenome;

            AddNotifications(new Contract<Nome>()
                .Requires()
                .IsGreaterOrEqualsThan(3, PrimeiroNome.Length, "Nome.PrimeiroNome", "O primero nome do candidato não poder ter menos de 3 caracteres")
                .IsGreaterOrEqualsThan(4, Sobrenome.Length, "Nome.Sobrenome", "O Sobrenome nome do candidato não poder ter menos de 4 caracteres")
                .IsNotEmpty(PrimeiroNome,"O primeiro nome não pode ser vazio")
                .IsNotEmpty(Sobrenome, "O sobrenome nome não pode ser vazio")
                );
        }

        public string PrimeiroNome { get; private set; }
        public string Sobrenome { get; private set; }
    }
}
