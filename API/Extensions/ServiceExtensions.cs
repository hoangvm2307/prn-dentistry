using prn_dentistry.API.Repositories;
using prn_dentistry.API.Services;

namespace prn_dentistry.API.Extensions
{
  public static class ServiceExtensions
  {
    public static IServiceCollection AddServiceDependencyGroup(this IServiceCollection services)
    {
      services.AddScoped<IServiceService, ServiceService>();
      services.AddScoped<IServiceRepository, ServiceRepository>();

      return services;
    }
  }
}