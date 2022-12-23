using AutoMapper;
using UrnaEletronica.AppServices.Interfaces;
using UrnaEletronica.AppServices.ViewModel;
using UrnaEletronica.Domains.Interfaces;

namespace UrnaEletronica.AppServices.Services
{
    public sealed class CandidatoServices : ICandidatoService
    {
        private readonly ICandidatoRepository _candidatoRepository;
        private readonly IMapper _mapper;

        public CandidatoServices(ICandidatoRepository candidatoRepository, IMapper mapper)
        {
            _candidatoRepository = candidatoRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<CandidatoViewModel>> GetAllAsync()
        {
            return _mapper.Map<IEnumerable<CandidatoViewModel>>(await _candidatoRepository.GetAllAsync());
        }
    }
}
