namespace app_backend.DTOs;

public class UserDto
{
    public int id { get; set; }
    public string email { get; set; }
    public string first_name { get; set; }
    public string last_name { get; set; }
    public string account_type { get; set; }  // "athlete", "parent", "coach"
    public string sport { get; set; } // "soccer", "basketball", "softball", "volleyball"
    public int zip_code { get; set; }
    public DateOnly birth_date { get; set; }
    public string linked_accounts { get; set; }
    public int positions { get; set; }
    public DateTime created_at { get; set; }
}

public class UserUpdateDto
{
    public string first_name { get; set; }
    public string last_name { get; set; }
    public string sport { get; set; } // "soccer", "basketball", "softball", "volleyball"
    public int positions { get; set; }


}