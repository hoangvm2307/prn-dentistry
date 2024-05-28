using prn_dentistry.API.Repositories;
using prn_dentistry.API.Services;

namespace prn_dentistry.API.Extensions
{
  public static class ClinicScheduleExtensions
  {
    public static IServiceCollection AddClinicScheduleDependencyGroup(this IServiceCollection services)
    {
      services.AddScoped<IClinicScheduleService, ClinicScheduleService>();
      services.AddScoped<IClinicScheduleRepository, ClinicScheduleRepository>();

      return services;
    }
  }
}