using System;
using HarmonyTools;
using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        private Notes _notes;

        [SetUp]
        public void Setup()
        {
            _notes = new Notes();
        }

        [Test]
        public void ScaleNotes()
        {
            foreach (var n in _notes.EnumerateNotes(NoteName.G | NoteName.Sharp, Scales.HarmonicMinor))
                Console.WriteLine(n);

            Assert.Pass();
        }


        [Test]
        public void ChordNotes()
        {
            foreach (var n in _notes.EnumerateNotes(NoteName.G | NoteName.Sharp, Chords.DominantThirteen))
                Console.WriteLine(n);

            Assert.Pass();
        }


        [Test]
        public void ParseNoteName()
        {
            var nn = Notes.Parse("C#");

            Console.WriteLine(nn.Name);

            Assert.Pass();
        }

        [Test]
        public void ProgressionChordNotes()
        {
            var nn = Notes.Parse("C");

            foreach (var chord in Progressions.HarmonicMinor451.GetProgressionChords(nn))
            {
                foreach (var note in chord) Console.WriteLine(note);

                Console.WriteLine("==================================");
            }
        }

        [Test]
        public void Keyboard()
        {
            var keyboard = new Keyboard(-1, 8);

            foreach (var midiKey in keyboard.Keys())
            {
                Console.WriteLine($"Midi Number {midiKey.NoteNumber} \tOctave {midiKey.Octave.OctaveNumber} \t Note {midiKey.Note}");
            }
        }
    }
}