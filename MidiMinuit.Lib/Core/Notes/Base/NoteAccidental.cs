using System;

namespace MidiMinuit.Lib.Core.Notes
{
    public sealed class NoteAccidental
    {
        private NoteAccidental(int value, int order, string name, string symbol)
        {
            Value = value;
            Order = order;
            Name = name;
            Symbol = symbol;
        }

        /// <summary>
        /// Gets Natural
        /// </summary>
        public static NoteAccidental Natural { get; }
            = new NoteAccidental(0, 0, nameof(Natural), string.Empty);

        /// <summary>
        /// Gets bémol
        /// </summary>
        public static NoteAccidental Flat { get; }
            = new NoteAccidental(-1, 1, nameof(Flat), "♭");

        /// <summary>
        /// Gets dièse
        /// </summary>
        public static NoteAccidental Sharp { get; }
            = new NoteAccidental(1, 2, nameof(Sharp), "♯");

        /// <summary>
        /// Gets double bémol
        /// </summary>
        public static NoteAccidental DoubleFlat { get; }
            = new NoteAccidental(-2, 3, nameof(DoubleFlat), "♭♭");

        /// <summary>
        /// Gets double dièse
        /// </summary>
        public static NoteAccidental DoubleSharp { get; }
            = new NoteAccidental(2, 4, nameof(DoubleSharp), "♯♯");

        public static NoteAccidental GetAccidental(string accidental)
        {
            if (accidental.Length < 0 || accidental.Length > 2)
            {
                throw new ArgumentException("invalid format");
            }

            switch (accidental.ToLowerInvariant())
            {
                case "":
                    return Natural;
                case "b":
                case "♭":
                    return Flat;
                case "#":
                case "♯":
                    return Sharp;
                case "bb":
                case "♭♭":
                    return DoubleFlat;
                case "##":
                case "♯♯":
                    return DoubleSharp;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public int Value { get; }

        public int Order { get; }

        public string Name { get; }

        public string Symbol { get; }

        public override string ToString()
            => Symbol;
    }
}