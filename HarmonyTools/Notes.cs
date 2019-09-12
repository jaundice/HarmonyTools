using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace HarmonyTools
{
    public class Notes
    {
        private static readonly Note[] _notes =
        {
            new Note(NoteName.C),
            new Note(NoteName.C | NoteName.Sharp, NoteName.D | NoteName.Flat),
            new Note(NoteName.D),
            new Note(NoteName.D | NoteName.Sharp, NoteName.E | NoteName.Flat),
            new Note(NoteName.E),
            new Note(NoteName.F),
            new Note(NoteName.F | NoteName.Sharp, NoteName.G | NoteName.Flat),
            new Note(NoteName.G),
            new Note(NoteName.G | NoteName.Sharp, NoteName.A | NoteName.Flat),
            new Note(NoteName.A),
            new Note(NoteName.A | NoteName.Sharp, NoteName.B | NoteName.Flat),
            new Note(NoteName.B)
        };

        private static readonly DoubleLinkedListEntry<Note> Chromatic = LinkNotesList();

        private static readonly Dictionary<NoteName, DoubleLinkedListEntry<Note>> NoteNameIndex =
            CreateNameIndex(Chromatic);

        private static readonly Dictionary<Note, DoubleLinkedListEntry<Note>>
            NoteIndex = CreateNoteIndex(NoteNameIndex);

        private static Dictionary<Note, DoubleLinkedListEntry<Note>> CreateNoteIndex(
            Dictionary<NoteName, DoubleLinkedListEntry<Note>> noteNameIndex)
        {
            var res = new Dictionary<Note, DoubleLinkedListEntry<Note>>();

            foreach (var doubleLinkedListEntry in noteNameIndex)
                res.Add(doubleLinkedListEntry.Value.Item, doubleLinkedListEntry.Value);

            return res;
        }

        private static Dictionary<NoteName, DoubleLinkedListEntry<Note>> CreateNameIndex(
            DoubleLinkedListEntry<Note> chromatic)
        {
            var res = new Dictionary<NoteName, DoubleLinkedListEntry<Note>>();
            var root = chromatic;
            var el = chromatic;

            do
            {
                res.Add(el.Item.Name, el);
                el = el.Forward;
            } while (!ReferenceEquals(root, el));

            return res;
        }


        private static DoubleLinkedListEntry<Note> LinkNotesList()
        {
            var elements = _notes.Select(a => new DoubleLinkedListEntry<Note>(a)).ToList();
            for (var i = 0; i < elements.Count - 1; i++) elements[i].Append(elements[i + 1]);

            elements[elements.Count - 1].Append(elements[0]);

            return elements[0];
        }

        public IEnumerable<Note> EnumerateNotes(NoteName root, Pattern pattern)
        {
            var n = NoteNameIndex[root];

            return EnumerateNotes(n, pattern);
        }

        public IEnumerable<Note> EnumerateNotes(Note root, Pattern pattern)
        {
            return new ScaleEnumerator(NoteIndex[root], pattern);
        }


        private IEnumerable<Note> EnumerateNotes(DoubleLinkedListEntry<Note> root, Pattern pattern)
        {
            return new ScaleEnumerator(root, pattern);
        }

        public IEnumerable<Note> EnumerateNotes(NoteName root, Chord chord)
        {
            return EnumerateNotes(root, chord.Pattern);
        }

        public static Note Parse(string note)
        {
            var nn = ParseName(note);
            return NoteNameIndex[nn].Item;
        }

        public static NoteName ParseName(string note)
        {
            var trimmed = note.Trim();
            if (trimmed.Length > 2)
                throw new ArgumentException();

            var match = Regex.Match(trimmed, "([A-G])([#b]?)");
            if (!match.Success)
                throw new ArgumentException();

            var letter = match.Groups[1];
            var mod = match.Groups[2];

            var modifier = NoteName.Empty;

            switch (mod.Value)
            {
                case "#":
                    modifier = NoteName.Sharp;
                    break;
                case "b":
                    modifier = NoteName.Flat;
                    break;
            }

            switch (letter.Value)
            {
                case "A":
                    return NoteName.A | modifier;
                case "B":
                    return NoteName.B | modifier;
                case "C":
                    return NoteName.C | modifier;
                case "D":
                    return NoteName.D | modifier;
                case "E":
                    return NoteName.E | modifier;
                case "F":
                    return NoteName.F | modifier;
                case "G":
                    return NoteName.G | modifier;
                default:
                    return NoteName.Empty;
            }
        }

        public IEnumerable<Note> EnumerateNotes(string root, Pattern pattern)
        {
            return EnumerateNotes(Parse(root), pattern);
        }
    }
}