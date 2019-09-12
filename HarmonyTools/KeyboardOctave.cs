using System.Collections.Generic;
using System.Linq;

namespace HarmonyTools
{
    public class KeyboardOctave
    {
        public int OctaveNumber { get; }

        public MidiKey[] Keys { get; }

        private Dictionary<Note, MidiKey> NoteKeyMap { get; }

        public KeyboardOctave(int octaveNumber)
        {
            var n = new Notes();

            OctaveNumber = octaveNumber;

            var minNoteNumber = (octaveNumber + 1) * 12;

            var notes = n.EnumerateNotes("C", Scales.Chromatic).ToArray();

            Keys = Enumerable.Range(minNoteNumber, 12).Select(a =>
            {
                var not = notes[a - minNoteNumber];

                return new MidiKey(a, not, this);
            }).ToArray();

            NoteKeyMap = Keys.ToDictionary(a => a.Note);
        }

        public MidiKey KeyForNote(Note note)
        {
            return NoteKeyMap[note];
        }

        public MidiKey KeyForNote(string note)
        {
            return KeyForNote(Notes.Parse(note));
        }
    }
}