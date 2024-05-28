using prn_dentistry.API.Repositories;
using prn_dentistry.API.Services;

namespace prn_dentistry.API.Extensions
{
  public static class AppointmentExtensions
  {
    public static IServiceCollection AddAppointmentDependencyGroup(this IServiceCollection services)
    {
      services.AddScoped<IAppointmentService, AppointmentService>();
      services.AddScoped<IAppointmentRepository, AppointmentRepository>();

      return services;
    }
  }
}