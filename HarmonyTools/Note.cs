using System;

namespace HarmonyTools
{
    public struct Note : IEquatable<Note>
    {
        public static readonly Note Unknown = new Note(NoteName.Empty);

        public NoteName Name { get; }

        public NoteName AlternateName { get; }

        internal Note(NoteName name, NoteName alternateName)
        {
            Name = name;
            AlternateName = alternateName;
        }

        internal Note(NoteName name) : this(name, NoteName.Empty)
        {
        }

        public override string ToString()
        {
            return AlternateName == NoteName.Empty
                ? FriendlyName(Name)
                : string.Concat(FriendlyName(Name), "/", FriendlyName(AlternateName));
        }


        private static string FriendlyName(NoteName nn)
        {
            var modifier = nn.HasFlag(NoteName.Sharp) ? "#" : nn.HasFlag(NoteName.Flat) ? "b" : "";
            string letter = null;

            if (nn.HasFlag(NoteName.A))
                letter = "A";
            else if (nn.HasFlag(NoteName.B))
                letter = "B";
            else if (nn.HasFlag(NoteName.C))
                letter = "C";
            else if (nn.HasFlag(NoteName.D))
                letter = "D";
            else if (nn.HasFlag(NoteName.E))
                letter = "E";
            else if (nn.HasFlag(NoteName.F))
                letter = "F";
            else if (nn.HasFlag(NoteName.G))
                letter = "G";

            return string.Concat(letter, modifier);
        }

        public bool Equals(Note other)
        {
            return Name == other.Name && AlternateName == other.AlternateName;
        }

        public override bool Equals(object obj)
        {
            return obj is Note other && Equals(other);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return ((int) Name * 397) ^ (int) AlternateName;
            }
        }
    }
}