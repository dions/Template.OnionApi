using Example.Data.Interfaces;
using Example.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace Example.Data
{
    public static class DataModuleExtensions
    {
        public static IServiceCollection RegisterDataModules(this IServiceCollection services)
        {
            // Do additional service initialization
            services.TryAddScoped<ICustomerRepository, CustomerRepository>();

            return services;
        }
    }
}
