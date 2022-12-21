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
                );
        }

        public string PrimeiroNome { get; private set; }
        public string Sobrenome { get; private set; }
    }
}
