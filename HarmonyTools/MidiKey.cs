using System;
using System.Reflection;
using System.Text;

namespace HarmonyTools
{
    public class MidiKey
    {
        public int NoteNumber { get; }
        public Note Note { get; }
        public KeyboardOctave Octave { get; }

        internal MidiKey(int noteNumber, Note note, KeyboardOctave octave)
        {
            NoteNumber = noteNumber;
            Note = note;
            Octave = octave;

        }
    }
}
