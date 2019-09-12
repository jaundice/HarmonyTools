using System;

namespace HarmonyTools
{
    [Flags]
    public enum ChordQuality
    {
        None,
        Triad,
        Minor,
        Major,
        Augmented,
        Diminished,
        Suspended,
        Dominant,
        Extended,
        Six,
        Seven,
        Nine,
        Eleven,
        Thirteen
    }
}