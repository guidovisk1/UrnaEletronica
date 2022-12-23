using Microsoft.Extensions.DependencyInjection;
using UrnaEletronica.AppServices.Interfaces;
using UrnaEletronica.AppServices.Services;
using UrnaEletronica.Domains.Interfaces;
using UrnaEletronica.Infra.Data.Context;
using UrnaEletronica.Infra.Data.Repositories;

namespace UrnaEletronica.Infra.CrossCutting.IoC;

public static class NativeInjector
{
    public static void RegisterServices(this IServiceCollection services)
    {
        services.AddDbContext<UrnaEletronicaContext>();
        services.AddScoped<UrnaEletronicaContext>();

        services.AddScoped<ICandidatoRepository, CandidatoRepository>();
        services.AddScoped<ICandidatoService, CandidatoServices>();
    }
}