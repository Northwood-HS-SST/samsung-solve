using app_backend.Services.Interfaces;
using System.Net.Http.Json;
using app_backend.DTOs;
using Microsoft.Maui.Storage;

namespace app_backend.Services.Classes;

public class AuthService : IAuthService
{
    private readonly HttpClient _httpClient;
    private const string TokenKey = "auth_token";

    public AuthService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<LoginResponseDto> LoginAsync(LoginRequestDto request)
    {
        try
        {
            var response = await _httpClient.PostAsJsonAsync("/api/auth/login", request);

            if (!response.IsSuccessStatusCode)
            {
                var error = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"Login failed: {error}");
                return null;
            }

            var content = response.Content;

            var result = await response.Content.ReadFromJsonAsync<LoginResponseDto>();

            if (result?.token != null)
            {
                // Store token securely
                await SecureStorage.SetAsync(TokenKey, result.token);
            }

            return result;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Login error: {ex.Message}");
            return null;
        }
    }

    public async Task<UserDto> RegisterAsync(RegisterRequestDto request)
    {
        try
        {
            var response = await _httpClient.PostAsJsonAsync("/api/auth/register", request);

            if (!response.IsSuccessStatusCode)
            {
                var error = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"Register failed: {error}");
                return null;
            }

            var user = await response.Content.ReadFromJsonAsync<UserDto>();
            return user;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Register error: {ex.Message}");
            return null;
        }
    }

    public async Task<string> GetTokenAsync()
    {
        try
        {
            return await SecureStorage.GetAsync(TokenKey);
        }
        catch
        {
            return null;
        }
    }

    public async Task LogoutAsync()
    {
        SecureStorage.Remove(TokenKey);
        await Task.CompletedTask;
    }

    public async Task<bool> IsAuthenticatedAsync()
    {
        var token = await GetTokenAsync();
        return !string.IsNullOrEmpty(token);
    }
}