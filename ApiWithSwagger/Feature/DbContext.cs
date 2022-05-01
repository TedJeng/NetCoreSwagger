using Api.Repository.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ApiWithSwagger.Feature
{
    public static class DbContext
    {
        public static void ConfigureSqlContext(this IServiceCollection services, IConfiguration config)
        {
            var connectionString = config["context:connectionString"];
            services.AddDbContext<AWContext>(options =>
                                    options.UseSqlServer(connectionString));
        }
    }
}
