using AutoMapper;
using UrnaEletronica.AppServices.ViewModel;
using UrnaEletronica.Domains.Entities;

namespace UrnaEletronica.AppServices.AutoMapper;

public sealed class DomainToViewModelProfile : Profile
{
    public DomainToViewModelProfile()
    {
        CreateMap<Candidato, CandidatoViewModel>();
    }
}
