using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UrnaEletronica.Application.Interfaces;
using UrnaEletronica.Application.ViewModel;
using UrnaEletronica.Domains.Interfaces;

namespace UrnaEletronica.Application.Services
{
    public class CandidatoServices : ICandidatoService
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
