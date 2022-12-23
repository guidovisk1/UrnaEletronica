using UrnaEletronica.Domains.ValueObjects;

namespace UrnaEletronica.AppServices.ViewModel
{
    public sealed class CandidatoViewModel
    {
        public Guid Id { get; private set; }
        public Nome Nome { get; private set; }
        public Idade Idade { get; private set; }
        public Partido Partido { get; private set; }
        public string NumeroVoto { get; private set; }
        public string Cargo { get; private set; }
    }
}
