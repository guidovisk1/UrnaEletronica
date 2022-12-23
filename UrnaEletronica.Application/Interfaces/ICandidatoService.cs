using UrnaEletronica.Application.ViewModel;

namespace UrnaEletronica.Application.Interfaces
{
    public interface ICandidatoService
    {
        Task<IEnumerable<CandidatoViewModel>> GetAllAsync();
    }
}
