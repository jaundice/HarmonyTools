using System.Collections.Generic;
using System.Linq;

namespace HarmonyTools
{
    public class Progression
    {
        public Progression(Pattern scale, int[] scaleDegrees, Chord[] chords)
        {
            Scale = scale;
            ScaleDegrees = scaleDegrees;
            Chords = chords;
        }

        public Pattern Scale { get; }

        public int[] ScaleDegrees { get; }

        public Chord[] Chords { get; }

        public IEnumerable<IEnumerable<Note>> GetProgressionChords(string root)
        {
            return GetProgressionChords(Notes.Parse(root));
        }

        public IEnumerable<IEnumerable<Note>> GetProgressionChords(Note root)
        {
            var n = new Notes();

            var scale = n.EnumerateNotes(root, Scale).ToArray();

            for (var i = 0; i < ScaleDegrees.Length; i++)
            {
                var chordRoot = scale[ScaleDegrees[i] - 1];
                yield return n.EnumerateNotes(chordRoot, Chords[i].Pattern);
            }
        }
    }
}