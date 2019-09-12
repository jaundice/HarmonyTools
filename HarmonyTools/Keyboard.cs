using System.Collections.Generic;

namespace HarmonyTools
{
    public class Keyboard
    {
        public KeyboardOctave[] Octaves { get; }

        private Dictionary<int, MidiKey> KeyMap { get; }


        public Keyboard(int lowOctave, int highOctave)
        {
            List<KeyboardOctave> octaves =  new List<KeyboardOctave>();
            KeyMap = new Dictionary<int, MidiKey>();

            for (var i = lowOctave; i < highOctave + 1; i++)
            {
                var oct = new KeyboardOctave(i);

                foreach (var midiKey in oct.Keys)
                {
                    KeyMap.Add(midiKey.NoteNumber, midiKey);
                }

                octaves.Add(oct);
            }

            this.Octaves = octaves.ToArray();
        }

        public IEnumerable<MidiKey> Keys()
        {
            foreach (var keyboardOctave in Octaves)
            {
                foreach (var keyboardOctaveKey in keyboardOctave.Keys)
                {
                    yield return keyboardOctaveKey;
                }
            }
        }

        public MidiKey GetKey(int midiNoteNumber)
        {
            return KeyMap[midiNoteNumber];
        }
    }
}