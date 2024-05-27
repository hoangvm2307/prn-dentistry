using prn_dentistry.API.Repositories;
using prn_dentistry.API.Services;

namespace prn_dentistry.API.DependencyInjection
{
  public static class AccountExtensions
  {
    public static IServiceCollection AddAccountDependencyGroup(this IServiceCollection services)
    {
      services.AddScoped<IAccountService, AccountService>();
      services.AddScoped<IAccountRepository, AccountRepository>();

      return services;
    }
  }
}