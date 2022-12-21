

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
        }

        public string Nome { get; private set; }
        public DateOnly DataCriacao { get; private set; }
        public string Sigla { get; private set; }
    }
}
