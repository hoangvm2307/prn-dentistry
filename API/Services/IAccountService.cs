using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using prn_dentistry.API.DTOs.AccountDto;


namespace prn_dentistry.API.Services
{
  public interface IAccountService
  {
    Task<IdentityResult> RegisterAsync(RegisterDto registerDto);
    Task<UserDto> LoginAsync(LoginDto loginDto);
    Task<ActionResult<UserDto>> GetCurrentUser(string username);
  }
}