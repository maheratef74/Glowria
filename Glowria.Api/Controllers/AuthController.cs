
using Glowria.Application.Commands.Register;
using Microsoft.AspNetCore.Mvc;

namespace Glowria.Api.Controllers;

[ApiController]
[Route("api/auth")]
public class AuthController : ControllerBase
{
    [HttpPost("register")]
    public async Task<IActionResult> Register(RegisterRequest request)
        => Ok(await _authService.RegisterAsync(request));
    
   
}