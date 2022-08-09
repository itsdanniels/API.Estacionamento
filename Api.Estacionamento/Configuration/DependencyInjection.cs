using Api.Estacionamento.Repositories;
using Api.Estacionamento.Repositories.Interfaces;
using Api.Estacionamento.Services;
using Api.Estacionamento.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Api.Estacionamento.Configuration
{
    public static class DependencyInjection
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<IEstacionamentoService, EstacionamentoService>();
            services.AddScoped<IEstacionamentoRepository, EstacionamentoRepository>();

            return services;
        }
    }
}
