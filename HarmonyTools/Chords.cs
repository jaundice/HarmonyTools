namespace HarmonyTools
{
    public class Chords
    {
        public static Chord MinorTriad = new Chord(ChordQuality.Triad | ChordQuality.Minor,
            new[] {Intervals.Unison, Intervals.MinorThird, Intervals.PerfectFifth});

        public static Chord MinorSix = new Chord(ChordQuality.Extended | ChordQuality.Minor | ChordQuality.Six,
            new[] {Intervals.Unison, Intervals.MinorThird, Intervals.PerfectFifth, Intervals.MajorSixth});

        public static Chord MinorFlatSix = new Chord(ChordQuality.Extended | ChordQuality.Minor | ChordQuality.Six,
            new[] {Intervals.Unison, Intervals.MinorThird, Intervals.PerfectFifth, Intervals.MinorSixth});

        public static Chord MinorSeven = new Chord(ChordQuality.Extended | ChordQuality.Minor | ChordQuality.Seven,
            new[] {Intervals.Unison, Intervals.MinorThird, Intervals.PerfectFifth, Intervals.MinorSeventh});

        public static Chord MinorMajorSeventh =
            new Chord(ChordQuality.Extended | ChordQuality.Minor | ChordQuality.Seven,
                new[] {Intervals.Unison, Intervals.MinorThird, Intervals.PerfectFifth, Intervals.MajorSeventh});

        public static Chord HalfDiminished =
            new Chord(ChordQuality.Extended | ChordQuality.Minor | ChordQuality.Seven | ChordQuality.Diminished,
                new[] {Intervals.Unison, Intervals.MinorThird, Intervals.DiminishedFifth, Intervals.MinorSeventh});

        public static Chord Diminished =
            new Chord(ChordQuality.Extended | ChordQuality.Minor | ChordQuality.Seven | ChordQuality.Diminished,
                new[] {Intervals.Unison, Intervals.MinorThird, Intervals.DiminishedFifth, Intervals.MajorSixth});

        public static Chord MinorNine =
            new Chord(ChordQuality.Extended | ChordQuality.Minor | ChordQuality.Seven | ChordQuality.Nine,
                new[]
                {
                    Intervals.Unison, Intervals.MinorThird, Intervals.PerfectFifth, Intervals.MinorSeventh,
                    Intervals.MinorNinth
                });

        public static Chord MinorEleven = new Chord(
            ChordQuality.Extended | ChordQuality.Minor | ChordQuality.Seven | ChordQuality.Nine | ChordQuality.Eleven,
            new[]
            {
                Intervals.Unison, Intervals.MinorThird, Intervals.PerfectFifth, Intervals.MinorSeventh,
                Intervals.MajorNinth, Intervals.PerfectEleventh
            });

        public static Chord MinorThirteen = new Chord(
            ChordQuality.Extended | ChordQuality.Minor | ChordQuality.Seven | ChordQuality.Nine | ChordQuality.Eleven |
            ChordQuality.Thirteen,
            new[]
            {
                Intervals.Unison, Intervals.MinorThird, Intervals.PerfectFifth, Intervals.MinorSeventh,
                Intervals.MajorNinth, Intervals.PerfectEleventh, Intervals.MajorThirteenth
            });

        public static Chord MajorTriad = new Chord(ChordQuality.Triad | ChordQuality.Major,
            new[] {Intervals.Unison, Intervals.MajorThird, Intervals.PerfectFifth});

        public static Chord MajorSix = new Chord(ChordQuality.Extended | ChordQuality.Major | ChordQuality.Six,
            new[] {Intervals.Unison, Intervals.MajorThird, Intervals.PerfectFifth, Intervals.MajorSixth});

        public static Chord MajorSeven = new Chord(ChordQuality.Extended | ChordQuality.Major | ChordQuality.Seven,
            new[] {Intervals.Unison, Intervals.MajorThird, Intervals.PerfectFifth, Intervals.MajorSeventh});

        public static Chord SuspendedSecond =
            new Chord(ChordQuality.Triad | ChordQuality.Major | ChordQuality.Suspended,
                new[] {Intervals.Unison, Intervals.MajorSecond, Intervals.PerfectFifth});

        public static Chord SuspendedFourth =
            new Chord(ChordQuality.Triad | ChordQuality.Major | ChordQuality.Suspended,
                new[] {Intervals.Unison, Intervals.PerfectFourth, Intervals.PerfectFifth});

        public static Chord MajorNine =
            new Chord(ChordQuality.Extended | ChordQuality.Major | ChordQuality.Seven | ChordQuality.Nine,
                new[]
                {
                    Intervals.Unison, Intervals.MajorThird, Intervals.PerfectFifth, Intervals.MajorSeventh,
                    Intervals.MajorNinth
                });

        public static Chord MajorEleven = new Chord(
            ChordQuality.Extended | ChordQuality.Major | ChordQuality.Seven | ChordQuality.Nine | ChordQuality.Eleven,
            new[]
            {
                Intervals.Unison, Intervals.MajorThird, Intervals.PerfectFifth, Intervals.MajorSeventh,
                Intervals.MajorNinth, Intervals.PerfectEleventh
            });

        public static Chord MajorThirteen = new Chord(
            ChordQuality.Extended | ChordQuality.Major | ChordQuality.Seven | ChordQuality.Nine | ChordQuality.Eleven |
            ChordQuality.Thirteen,
            new[]
            {
                Intervals.Unison, Intervals.MajorThird, Intervals.PerfectFifth, Intervals.MajorSeventh,
                Intervals.MajorNinth, Intervals.PerfectEleventh, Intervals.MajorThirteenth
            });

        public static Chord DominantSeven =
            new Chord(ChordQuality.Extended | ChordQuality.Dominant | ChordQuality.Seven,
                new[] {Intervals.Unison, Intervals.MajorThird, Intervals.PerfectFifth, Intervals.MinorSeventh});

        public static Chord DiminishedTriad = new Chord(ChordQuality.Triad | ChordQuality.Diminished,
            new[] {Intervals.Unison, Intervals.MinorThird, Intervals.DiminishedFifth});

        public static Chord AugmentedTriad = new Chord(ChordQuality.Triad | ChordQuality.Augmented,
            new[] {Intervals.Unison, Intervals.MajorThird, Intervals.MinorSixth});

        public static Chord DominantNine =
            new Chord(ChordQuality.Extended | ChordQuality.Dominant | ChordQuality.Seven | ChordQuality.Nine,
                new[]
                {
                    Intervals.Unison, Intervals.MajorThird, Intervals.PerfectFifth, Intervals.MinorSeventh,
                    Intervals.MinorNinth
                });

        public static Chord DominantEleven = new Chord(
            ChordQuality.Extended | ChordQuality.Dominant | ChordQuality.Seven | ChordQuality.Nine |
            ChordQuality.Eleven,
            new[]
            {
                Intervals.Unison, Intervals.MajorThird, Intervals.PerfectFifth, Intervals.MinorSeventh,
                Intervals.MajorNinth, Intervals.PerfectEleventh
            });

        public static Chord DominantThirteen = new Chord(
            ChordQuality.Extended | ChordQuality.Dominant | ChordQuality.Seven | ChordQuality.Nine |
            ChordQuality.Eleven | ChordQuality.Thirteen,
            new[]
            {
                Intervals.Unison, Intervals.MajorThird, Intervals.PerfectFifth, Intervals.MinorSeventh,
                Intervals.MajorNinth, Intervals.PerfectEleventh, Intervals.MajorThirteenth
            });
    }
}