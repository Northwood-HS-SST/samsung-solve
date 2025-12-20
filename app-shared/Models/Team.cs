using app_shared.Enums;

namespace app_backend.Models;

public class Team
{
    public UInt16 Id { get; internal set; }
    public string Name { get; internal set; }
    public SportType Sport { get; internal set; }
    public Tuple<int, int> AgeRange { get; internal set; }
}