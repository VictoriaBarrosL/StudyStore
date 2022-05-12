using StudyStoreApp.Extensions;
using StudyStore.Business.Interfaces;
using StudyStore.Business.Notificacoes;
using StudyStore.Business.Services;
using StudyStore.Data.Context;
using StudyStore.Data.Repository;
using Microsoft.AspNetCore.Mvc.DataAnnotations;
using Microsoft.Extensions.DependencyInjection;

namespace StudyStoreApp.Configurations
{
        public static class DependencyInjectionConfig
        {
            public static IServiceCollection ResolveDependencies(this IServiceCollection services)
            {
                services.AddScoped<MeuDbContext>();
                services.AddScoped<IProdutoRepository, ProdutoRepository>();
                services.AddScoped<IFornecedorRepository, FornecedorRepository>();
                services.AddScoped<IEnderecoRepository, EnderecoRepository>();
                services.AddSingleton<IValidationAttributeAdapterProvider, MoedaValidationAttributeAdapterProvider>();

                services.AddScoped<INotificador, Notificador>();
                services.AddScoped<IFornecedorService, FornecedorService>();
                services.AddScoped<IProdutoService, ProdutoService>();

                return services;
            }
        }
    }
}
}
