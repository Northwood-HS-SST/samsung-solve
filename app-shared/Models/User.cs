using System;
using System.Collections.Generic;
using System.Text;
using app_shared.Enums;

namespace app_backend.Models
{
    internal class User
    { 
        public UInt16 UserId { get; internal set; }

        public string FirstName { get; internal set; }
        public string LastName { get; internal set; }
        public UInt16 ZipCode { get; internal set; }
        public DateOnly Birthdate { get; internal set; }


    }

    internal class CoachUser : User
    {
        public SportType Sport { get; internal set; }
    }

    internal class ParentUser : User
    {
        public IReadOnlyList<UInt16> Subusers { get; internal set; }
    }

    internal class AthleteUser : User
    {
        public SportType Sport { get; internal set; }

        // sport-specific enums, please refactor
        public VolleyballPosition VolleyballPositions { get; internal set; } = VolleyballPosition.None;
        public BasketballPosition BasketballPositions { get; internal set;} = BasketballPosition.None;
        public SoccerPosition SoccerPositions { get; internal set; } = SoccerPosition.None;
        public SoftballPosition SoftballPositions { get; internal set; } = SoftballPosition.None;
    }

    
}
