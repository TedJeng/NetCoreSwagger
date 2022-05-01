using Api.Repository.Service;
using ApiWithSwagger.Helper;
using Microsoft.Extensions.DependencyInjection;

namespace ApiWithSwagger.Feature
{
    public static class DependInject
    {
        public static void DI(this IServiceCollection services)
        {
            services.AddScoped<IApiService, ApiService>();
            services.AddScoped<Map>();
        }
    }
}
