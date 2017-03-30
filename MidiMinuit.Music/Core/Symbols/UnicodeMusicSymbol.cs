namespace MidiMinuit.Music.Core.Symbols
{
    public sealed class UnicodeMusicSymbol
    {
        private UnicodeMusicSymbol(int order, string name, string symbol, char unicodeChar)
        {
            Order = order;
            Name = name;
            Symbol = symbol;
            UnicodeChar = unicodeChar;
        }

        public static UnicodeMusicSymbol QuarterNote { get; }
            = new UnicodeMusicSymbol(0, nameof(QuarterNote), "♩", '\u2669');

        public static UnicodeMusicSymbol EighthNote { get; }
            = new UnicodeMusicSymbol(1, nameof(EighthNote), "♪", '\u266A');

        public static UnicodeMusicSymbol BeamedEighthNotes { get; }
            = new UnicodeMusicSymbol(2, nameof(BeamedEighthNotes), "♫", '\u266B');

        public static UnicodeMusicSymbol BeamedSixteenthNotes { get; }
            = new UnicodeMusicSymbol(3, nameof(BeamedSixteenthNotes), "♬", '\u266C');

        public static UnicodeMusicSymbol MusicFlatSign { get; }
            = new UnicodeMusicSymbol(4, nameof(MusicFlatSign), "♭", '\u266D');

        public static UnicodeMusicSymbol MusicNaturalSign { get; }
            = new UnicodeMusicSymbol(5, nameof(MusicNaturalSign), "♮", '\u266E');

        public static UnicodeMusicSymbol MusicSharpSign { get; }
            = new UnicodeMusicSymbol(6, nameof(MusicSharpSign), "♯", '\u266F');

        public static UnicodeMusicSymbol MajorSeventhMajor { get; }
            = new UnicodeMusicSymbol(7, nameof(MajorSeventhMajor), "Δ", '\u0394');

        public int Order { get; }

        public string Name { get; }

        public string Symbol { get; }

        public char UnicodeChar { get; }

        public override string ToString()
            => Symbol;
    }
}