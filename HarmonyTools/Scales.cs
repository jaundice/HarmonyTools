namespace HarmonyTools
{
    public static class Scales
    {
        public static readonly Pattern Chromatic = new Pattern(new[] {0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1});
        public static readonly Pattern Major = new Pattern(new[] {0, 2, 2, 1, 2, 2, 2, 1});
        public static readonly Pattern Minor = new Pattern(new[] {0, 2, 1, 2, 2, 1, 2, 2});
        public static readonly Pattern MinorBlues = new Pattern(new[] {0, 3, 2, 2, 3, 2});
        public static readonly Pattern Blues = new Pattern(new[] {0, 3, 2, 1, 1, 3, 2});
        public static readonly Pattern MajorPentatonic = new Pattern(new[] {0, 2, 2, 3, 2, 3});
        public static readonly Pattern MinorPentatonic = new Pattern(new[] {0, 3, 2, 2, 3, 2});

        public static readonly Pattern NaturalMinor = new Chord(ChordQuality.None,
            new[]
            {
                Intervals.Unison, Intervals.MajorSecond, Intervals.MinorThird, Intervals.PerfectFourth,
                Intervals.PerfectFifth, Intervals.MinorSixth, Intervals.MinorSeventh
            }).Pattern;

        public static readonly Pattern HarmonicMinor = new Chord(ChordQuality.None,
            new[]
            {
                Intervals.Unison, Intervals.MajorSecond, Intervals.MinorThird, Intervals.PerfectFourth,
                Intervals.PerfectFifth, Intervals.MinorSixth, Intervals.MajorSeventh
            }).Pattern;
    }
}