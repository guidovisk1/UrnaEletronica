using UrnaEletronica.Domains.ValueObjects;

namespace UrnaEletronica.Application.ViewModel
{
    public sealed class CandidatoViewModel
    {
        public Guid Id { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int Idade { get; private set; }
        public string NomePartido { get; private set; }
        public string SiglaPartido { get; private set; }
    }
}
