namespace MidiMinuit.Lib.Core.Scales
{
    public sealed class ScaleType
    {
        private ScaleType(int order, string name)
        {
            Order = order;
            Name = name;
        }

        public static ScaleType Major { get; }
            = new ScaleType(0, nameof(Major));

        public static ScaleType MinorMelodic { get; }
            = new ScaleType(1, nameof(MinorMelodic));

        public static ScaleType MinorHarmonic { get; }
            = new ScaleType(2, nameof(MinorHarmonic));

        public static ScaleType MinorNaturalEolian { get; }
            = new ScaleType(3, nameof(MinorNaturalEolian));

        public static ScaleType ModeDorian { get; }
            = new ScaleType(4, nameof(ModeDorian));

        public static ScaleType ModeMixolydian { get; }
            = new ScaleType(5, nameof(ModeMixolydian));

        public static ScaleType ModeLydian { get; }
            = new ScaleType(6, nameof(ModeLydian));

        public static ScaleType ModeLydianB7 { get; }
            = new ScaleType(7, nameof(ModeLydianB7));

        public static ScaleType PentatonicMajor { get; }
            = new ScaleType(8, nameof(PentatonicMajor));

        public static ScaleType PentatonicMinor { get; }
            = new ScaleType(9, nameof(PentatonicMinor));

        public static ScaleType Blues { get; }
            = new ScaleType(10, nameof(Blues));

        public static ScaleType ModePhrygian { get; }
            = new ScaleType(11, nameof(ModePhrygian));

        public static ScaleType ModeLocrian { get; }
            = new ScaleType(12, nameof(ModeLocrian));

        public static ScaleType ModeLocrianBec2 { get; }
            = new ScaleType(13, nameof(ModeLocrianBec2));

        public static ScaleType ModeMixolydianB2B6 { get; }
            = new ScaleType(14, nameof(ModeMixolydianB2B6));

        public static ScaleType ModeAltered { get; }
            = new ScaleType(15, nameof(ModeAltered));

        public static ScaleType ModeLydianAdded { get; }
            = new ScaleType(16, nameof(ModeLydianAdded));

        public static ScaleType ModeDiminishedReverse { get; }
            = new ScaleType(17, nameof(ModeDiminishedReverse));

        public static ScaleType ModeDiminished { get; }
            = new ScaleType(18, nameof(ModeDiminished));

        public int Order { get; }

        public string Name { get; }

        public override string ToString()
            => Name;
    }
}