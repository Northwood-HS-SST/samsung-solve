using app_backend.DTOs;
using app_backend.Services.Interfaces;
using Microsoft.Maui.Storage;
using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace app_backend.Services.Classes;


public class UserService : IUserService
{
    private readonly HttpClient _httpClient;
    private readonly IAuthService _authService;

    public UserService(HttpClient httpClient, IAuthService authService)
    {
        _httpClient = httpClient;
        _authService = authService;
    }

    private async Task AddAuthHeaderAsync()
    {
        var token = await _authService.GetTokenAsync();
        if (!string.IsNullOrEmpty(token))
        {
            _httpClient.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer", token);
        }
        else
        {
            throw new Exception("Invalid token");
        }
    }

    public async Task<UserDto> GetCurrentUserAsync()
    {
        return UserDto.GetFake();
        try
        {
            await AddAuthHeaderAsync();

            var response = await _httpClient.GetAsync("/api/users/me");

            if (!response.IsSuccessStatusCode)
            {
                var error = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"Get user failed: {error}");
                return null;
            }

            var user = await response.Content.ReadFromJsonAsync<UserDto>();
            return user;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Get user error: {ex.Message}");
            return null;
        }
    }

    public async Task<UserDto> UpdateCurrentUserAsync(UserUpdateDto update)
    {
        return UserDto.GetFake();
            try
        {
            await AddAuthHeaderAsync();

            var response = await _httpClient.PutAsJsonAsync("/api/users/me", update);

            if (!response.IsSuccessStatusCode)
            {
                var error = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"Update user failed: {error}");
                return null;
            }

            var user = await response.Content.ReadFromJsonAsync<UserDto>();
            return user;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Update user error: {ex.Message}");
            return null;
        }
    }
}