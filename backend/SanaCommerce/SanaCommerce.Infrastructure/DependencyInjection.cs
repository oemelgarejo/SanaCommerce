using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SanaCommerce.Domain.Interfaces;
using SanaCommerce.Infrastructure.Data;
using SanaCommerce.Infrastructure.Repositories;

namespace SanaCommerce.Infrastructure
{
    public static class DependencyInjection
	{
		public static IServiceCollection ConfigureInfraestructureServices(this IServiceCollection services, IConfiguration configuration)
		{
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("SanaCommerceConnectionString")));

            //services.AddDbContext<ApplicationDbContext>(options =>
            //    options.UseNpgsql(configuration.GetConnectionString("SanaCommerceConnectionString"))
            //    .EnableDetailedErrors()
            //    .EnableSensitiveDataLogging());

            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IOrderRepository, OrderRepository>();
            return services;
        }
	}
}

