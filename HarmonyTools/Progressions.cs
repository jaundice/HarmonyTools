namespace HarmonyTools
{
    //https://www.apassion4jazz.net/progressions.html 
    public static class Progressions
    {
        public static readonly Progression Major451 = new Progression(Scales.Major, new[] {4, 5, 1},
            new[] {Chords.MajorTriad, Chords.MajorTriad, Chords.MajorTriad});

        public static readonly Progression Major251 = new Progression(Scales.Major, new[] {2, 5, 1},
            new[] {Chords.MinorTriad, Chords.MajorTriad, Chords.MajorTriad});

        public static readonly Progression Major521 = new Progression(Scales.Major, new[] {5, 2, 1},
            new[] {Chords.MajorTriad, Chords.MinorTriad, Chords.MajorTriad});

        public static readonly Progression Major541 = new Progression(Scales.Major, new[] {5, 4, 1},
            new[] {Chords.MajorTriad, Chords.MajorTriad, Chords.MajorTriad});

        public static readonly Progression Major321 = new Progression(Scales.Major, new[] {3, 2, 1},
            new[] {Chords.MinorTriad, Chords.MinorTriad, Chords.MajorTriad});

        public static readonly Progression Major341 = new Progression(Scales.Major, new[] {3, 2, 1},
            new[] {Chords.MinorTriad, Chords.MajorTriad, Chords.MajorTriad});

        public static readonly Progression HarmonicMinor451 = new Progression(Scales.HarmonicMinor, new[] {4, 5, 1},
            new[] {Chords.MinorTriad, Chords.MajorTriad, Chords.MinorTriad});

        public static readonly Progression HarmonicMinor541 = new Progression(Scales.HarmonicMinor, new[] {5, 4, 1},
            new[] {Chords.MajorTriad, Chords.MinorTriad, Chords.MinorTriad});
    }
}