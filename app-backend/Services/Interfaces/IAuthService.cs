using app_backend.DTOs;

namespace app_backend.Services.Interfaces;

public interface IAuthService
{
    Task<LoginResponseDto> LoginAsync(LoginRequestDto request);
    Task<UserDto> RegisterAsync(RegisterRequestDto request);
    Task<string> GetTokenAsync();
    Task LogoutAsync();
    Task<bool> IsAuthenticatedAsync();
}