using Glowria.Application.Dtos;
using Microsoft.AspNetCore.Identity.Data;
using RegisterRequest = Glowria.Application.Commands.Register.RegisterRequest;

namespace Glowria.Application.Services.Authentcation;

public interface IAuthService
{
    Task<AuthResponse> RegisterAsync(RegisterRequest request);
    Task<AuthResponse> LoginAsync(LoginRequest request);
}