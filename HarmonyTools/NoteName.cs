using System;

namespace HarmonyTools
{
    [Flags]
    public enum NoteName : short
    {
        Empty = 0,
        A = 0x1,
        B = A << 1,
        C = B << 1,
        D = C << 1,
        E = D << 1,
        F = E << 1,
        G = F << 1,
        Sharp = 0x1 << 13,
        Flat = Sharp << 1
    }
}