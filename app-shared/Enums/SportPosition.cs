namespace app_shared.Enums;

using System;

[Flags]
public enum VolleyballPosition
{
    None = 0,
    Setter = 1 << 0,
    OutsideHitter = 1 << 1,
    OppositeHitter = 1 << 2,
    MiddleBlocker = 1 << 3,
    Libero = 1 << 4,
    ServingSpecialist = 1 << 5,
}

[Flags]
public enum BasketballPosition
{
    None = 0,
    PointGuard = 1 << 0,
    ShootingGuard = 1 << 1,
    SmallForward = 1 << 2,
    PowerForward = 1 << 3,
    Center = 1 << 4,
}

[Flags]
public enum SoccerPosition
{
    None = 0,

    // defensive
    DefensiveLeft = 1 << 0,
    DefensiveRight = 1 << 1,

    // midfield
    MidfieldCenter = 1 << 2,
    MidfieldLeft = 1 << 3,
    MidfieldRight = 1 << 4,

    // forward
    ForwardStriker = 1 << 5,
    LeftStriker = 1 << 6,
    RightStriker = 1 << 7,

    // specials
    Sweeper = 1 << 8,
    Stopper = 1 << 9,
    Goalkeeper = 1 << 10,
}

[Flags]
public enum SoftballPosition
{
    None = 0,
    Infield = 1 << 0,
    Pitcher = 1 << 1,
    Catcher = 1 << 2,
    FirstBase = 1 << 3,
    SecondBase = 1 << 4,
    ThirdBase = 1 << 5,
    Shortstop = 1 << 6,
    Outfield = 1 << 7,
    LeftField = 1 << 8,
    CenterField = 1 << 9,
    RightField = 1 << 10,
}

