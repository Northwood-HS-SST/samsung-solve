namespace app_backend.DTOs;

public class LoginRequestDto
{
    public string email { get; set; }
    public string password { get; set; }
}

public class LoginResponseDto
{
    public string token { get; set; }
    public UserDto user { get; set; }
}

public class RegisterRequestDto
{
    public string email { get; set; }
    public string password { get; set; }
    public string first_name { get; set; }
    public string last_name { get; set; }
    public DateOnly birth_date { get; set; }
    public string account_type { get; set; }

}