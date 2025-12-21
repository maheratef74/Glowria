using Glowria.Application.Dtos;
using Microsoft.AspNetCore.Identity.Data;
using RegisterRequest = Glowria.Application.Commands.Register.RegisterRequest;

namespace Glowria.Application.Services.Authentcation;

public class AuthService : IAuthService
{
    public Task<AuthResponse> RegisterAsync(RegisterRequest request)
    {
        throw new NotImplementedException();
    }

    public Task<AuthResponse> LoginAsync(LoginRequest request)
    {
        throw new NotImplementedException();
    }
}