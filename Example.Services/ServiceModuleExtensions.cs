using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Template.Service.Interfaces;
using Template.Service.Services;

namespace Example.Service
{
    public static class ServiceModuleExtensions
    {
        public static IServiceCollection RegisterServiceModules(this IServiceCollection services)
        {
            services.TryAddScoped<ICustomerService, CustomerService>();

            // Do additional service initialization
            return services;
        }
    }
}
