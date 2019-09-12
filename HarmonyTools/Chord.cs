namespace HarmonyTools
{
    public class Chord
    {
        private Pattern _pattern;

        public Chord(ChordQuality quality, int[] spelling)
        {
            Spelling = spelling;
            Quality = quality;
        }


        public int[] Spelling { get; }

        public ChordQuality Quality { get; }

        public Pattern Pattern => _pattern ?? (_pattern = ConvertToPattern(this));

        private static Pattern ConvertToPattern(Chord chord)
        {
            var intervals = new int[chord.Spelling.Length];
            intervals[0] = 0;
            for (var i = 0; i < intervals.Length - 1; i++) intervals[i + 1] = chord.Spelling[i + 1] - chord.Spelling[i];

            return new Pattern(intervals);
        }
    }
}