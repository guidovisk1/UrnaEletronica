using UrnaEletronica.AppServices.ViewModel;

namespace UrnaEletronica.AppServices.Interfaces
{
    public interface ICandidatoService
    {
        Task<IEnumerable<CandidatoViewModel>> GetAllAsync();
    }
}
