using System;
using System.Reflection;
using System.Text;

namespace HarmonyTools
{
    public class MidiKey
    {
        private readonly KeyboardOctave _Octave;
        public int NoteNumber { get; }
        public Note Note { get; }
        public int Octave => _Octave.OctaveNumber;

        internal MidiKey(int noteNumber, Note note, KeyboardOctave octave)
        {
            NoteNumber = noteNumber;
            Note = note;
            _Octave = octave;

        }
    }
}
