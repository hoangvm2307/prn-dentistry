using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using prn_dentistry.API.DTOs.Account;
using prn_dentistry.API.Services;

namespace prn_dentistry.API.Controllers
{
  public class AccountController : BaseApiController
  {
    private readonly IAccountService _accountService;

    public AccountController(IAccountService accountService)
    {
      _accountService = accountService;
    }

    [HttpPost("register")]
    public async Task<IActionResult> Register([FromBody] RegisterDTO registerDto)
    {
      if (registerDto == null || !ModelState.IsValid) return BadRequest("Invalid registration request");

      var result = await _accountService.RegisterAsync(registerDto);

      if (result.Succeeded) return Ok("User registered successfully");

      return BadRequest(result.Errors);
    }

    [HttpPost("login")]
    public async Task<ActionResult<UserDTO>> Login([FromBody] LoginDTO loginDto)
    {
      if (loginDto == null || !ModelState.IsValid) return BadRequest("Invalid login request");

      var user = await _accountService.LoginAsync(loginDto);

      if (user == null) return Unauthorized("Invalid user name or password");

      return user;
    }

    [Authorize]
    [HttpGet("currentUser")]
    public async Task<ActionResult<UserDTO>> GetCurrentUser()
    {
      return await _accountService.GetCurrentUser(User.Identity.Name);
    }

  }
}