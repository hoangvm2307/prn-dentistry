using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace prn_dentistry.API.Repositories
{
  public interface IAccountRepository
  {
    Task<IdentityResult> RegisterAsync(IdentityUser user, string password);
    Task<Microsoft.AspNetCore.Identity.SignInResult> LoginAsync(string username, string password);
    Task<IdentityUser> GetUserByUsernameAsync(string username);
  }
}