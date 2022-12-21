

using Flunt.Validations;
using UrnaEletronica.Shared.ValueObjects;

namespace UrnaEletronica.Domains.ValueObjects
{
    public sealed class Partido : ValueObject
    {
        public Partido(string nome, DateOnly dataCriacao, string sigla)
        {
            Nome = nome;
            DataCriacao = dataCriacao;
            Sigla = sigla;

            AddNotifications(new Contract<Partido>()
                .Requires()
                .IsGreaterOrEqualsThan(3, Nome.Length, "Partido.Nome", "O nome do partido não pode ter menos de 3 caracteres")
                );
        }

        public string Nome { get; private set; }
        public DateOnly DataCriacao { get; private set; }
        public string Sigla { get; private set; }
    }
}
