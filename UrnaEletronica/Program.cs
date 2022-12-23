using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using UrnaEletronica.AppServices.AutoMapper;
using UrnaEletronica.Infra.CrossCutting.IoC;
using UrnaEletronica.Infra.Data.Context;

namespace UrnaEletronica
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var builder = new HostBuilder()
                .ConfigureServices((hostContext, services) =>
                {
                    services.AddSingleton<Form1>();
                    services.AddAutoMapper(typeof(DomainToViewModelProfile));
                    services.RegisterServices();
                });
            var host = builder.Build();

            using var serviceScope = host.Services.CreateScope();
            var services = serviceScope.ServiceProvider;
            try
            {
                var context = services.GetRequiredService<UrnaEletronicaContext>();
                AdicionarDados(context);

                var form1 = services.GetRequiredService<Form1>();
                Application.Run(form1);
            }
            catch (Exception)
            { }
        }

        private static void AdicionarDados(UrnaEletronicaContext context)
        {
            context.Candidatos.AddRange(InitialData.Lula, InitialData.Bolsonaro, InitialData.Ciro);
            context.SaveChanges();
        }
    }
}