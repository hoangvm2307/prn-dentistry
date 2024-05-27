using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using prn_dentistry.API.DTOs.Account;

namespace prn_dentistry.API.Services
{
  public interface IAccountService
  {
    Task<IdentityResult> RegisterAsync(RegisterDTO registerDto);
    Task<UserDTO> LoginAsync(LoginDTO loginDto);
    Task<ActionResult<UserDTO>> GetCurrentUser(string username);
  }
}