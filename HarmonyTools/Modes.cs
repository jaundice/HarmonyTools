namespace HarmonyTools
{
    public static class Modes
    {
        public static readonly Pattern Ionian = new Pattern(new[] {0, 2, 2, 1, 2, 2, 2, 1});
        public static readonly Pattern Dorian = new Pattern(new[] {0, 2, 1, 2, 2, 2, 1, 2});
        public static readonly Pattern Phyrgian = new Pattern(new[] {0, 1, 2, 2, 2, 1, 2, 2});
        public static readonly Pattern Lydian = new Pattern(new[] {0, 2, 2, 2, 1, 2, 2, 1});
        public static readonly Pattern Mixolydian = new Pattern(new[] {0, 2, 2, 1, 2, 2, 1, 2});
        public static readonly Pattern Aeolian = new Pattern(new[] {0, 2, 1, 2, 2, 1, 2, 2});
        public static readonly Pattern Locrian = new Pattern(new[] {0, 1, 2, 2, 1, 2, 2, 2});
    }
}