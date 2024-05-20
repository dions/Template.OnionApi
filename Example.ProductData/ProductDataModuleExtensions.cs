using Microsoft.Extensions.DependencyInjection;

namespace Example.ProductData
{
    public static class ProductDataModuleExtensions
    {
        public static IServiceCollection RegisterProductDataModules(this IServiceCollection services)
        {
            services.AddDbContext<ProductDbContext>();

            return services;
        }
    }
}
