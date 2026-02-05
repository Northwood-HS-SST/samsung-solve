using Microsoft.Maui.Storage;

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

    public static UserDto GetFake()
    {
        UserDto fake = new UserDto();
        fake.account_type = "athlete";
        fake.email = "user@example.com";
        fake.first_name = "Jane";
        fake.last_name = "Doe";
        fake.sport = "softball";
        fake.zip_code = 00000;
        fake.birth_date = new DateOnly(2000, 1, 1);
        fake.linked_accounts = "";
        fake.positions = 0;
        fake.created_at = new DateTime(2026, 2, 4);

        return fake;
    }
}

public class UserUpdateDto
{
    public string first_name { get; set; }
    public string last_name { get; set; }
    public string sport { get; set; } // "soccer", "basketball", "softball", "volleyball"
    public int positions { get; set; }


}