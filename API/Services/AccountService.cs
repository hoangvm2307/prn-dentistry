using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using prn_dentistry.API.DTOs.Account;
using prn_dentistry.API.Repositories;

namespace prn_dentistry.API.Services
{
  public class AccountService : IAccountService
  {
    private readonly IAccountRepository _accountRepository;
    private readonly TokenService _tokenService;
    public AccountService(IAccountRepository accountRepository, TokenService tokenService)
    {
      _accountRepository = accountRepository;
      _tokenService = tokenService;
    }
    public async Task<UserDTO> LoginAsync(LoginDTO loginDto)
    {
      var signInResult = await _accountRepository.LoginAsync(loginDto.Username, loginDto.Password);

      if(signInResult.Succeeded){
        var user = await _accountRepository.GetUserByUsernameAsync(loginDto.Username);
        
        return new UserDTO {
          Email = user.Email,
          Token = await _tokenService.GenerateToken(user)
        };
      }

      return null;
    }

    public async Task<IdentityResult> RegisterAsync(RegisterDTO registerDto)
    {
      var user = new IdentityUser
      {
        UserName = registerDto.Username,
        Email = registerDto.Email
      };
      return await _accountRepository.RegisterAsync(user, registerDto.Password);
    }

    public async Task<ActionResult<UserDTO>> GetCurrentUser(string username){
      var user = await _accountRepository.GetUserByUsernameAsync(username);

      return new UserDTO{
        Email = user.Email,
        Token = await _tokenService.GenerateToken(user)
      };
    }
  }
}