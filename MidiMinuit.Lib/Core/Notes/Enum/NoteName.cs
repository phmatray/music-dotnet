using System;

namespace MidiMinuit.Lib.Core.Notes
{
    public sealed class NoteName
    {
        private NoteName(int value, int order, string name, string nameLatin)
        {
            Value = value;
            Order = order;
            Name = name;
            NameLatin = nameLatin;
        }

        public static NoteName C { get; }
            = new NoteName(0, 0, nameof(C), "Do");

        public static NoteName D { get; }
            = new NoteName(2, 1, nameof(D), "Ré");

        public static NoteName E { get; }
            = new NoteName(4, 2, nameof(E), "Mi");

        public static NoteName F { get; }
            = new NoteName(5, 3, nameof(F), "Fa");

        public static NoteName G { get; }
            = new NoteName(7, 4, nameof(G), "Sol");

        public static NoteName A { get; }
            = new NoteName(9, 5, nameof(A), "La");

        public static NoteName B { get; }
            = new NoteName(11, 6, nameof(B), "Si");

        public static NoteName GetName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException(nameof(name));
            }

            if (name.Length != 1)
            {
                throw new ArgumentException("invalid format");
            }

            switch (name.ToUpper())
            {
                case "C":
                    return C;
                case "D":
                    return D;
                case "E":
                    return E;
                case "F":
                    return F;
                case "G":
                    return G;
                case "A":
                    return A;
                case "B":
                    return B;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public int Value { get; }

        public int Order { get; }

        public string Name { get; }

        public string NameLatin { get; }

        public override string ToString()
            => Name;
    }
}