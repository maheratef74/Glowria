using Identity.Domain.Entities;

namespace Glowria.Application.Services.Authentcation;

public interface ITokenService
{
    Task<string> GenerateToken(ApplicationUser user, bool rememberMe);
}