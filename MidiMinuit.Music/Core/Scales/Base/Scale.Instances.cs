namespace MidiMinuit.Music.Core.Scales
{
    public partial class Scale
    {
        public static Scale Major
            => Create(ScaleAlias.Major);

        public static Scale MinorMelodic
            => Create(ScaleAlias.MinorMelodic);

        public static Scale MinorHarmonic
            => Create(ScaleAlias.MinorHarmonic);

        public static Scale MinorNaturalEolian
            => Create(ScaleAlias.MinorNaturalEolian);

        public static Scale ModeDorian
            => Create(ScaleAlias.ModeDorian);

        public static Scale ModeMixolydian
            => Create(ScaleAlias.ModeMixolydian);

        public static Scale ModeLydian
            => Create(ScaleAlias.ModeLydian);

        public static Scale ModeLydianB7
            => Create(ScaleAlias.ModeLydianB7);

        public static Scale PentatonicMajor
            => Create(ScaleAlias.PentatonicMajor);

        public static Scale PentatonicMinor
            => Create(ScaleAlias.PentatonicMinor);

        public static Scale Blues
            => Create(ScaleAlias.Blues);

        public static Scale ModePhrygian
            => Create(ScaleAlias.ModePhrygian);

        public static Scale ModeLocrian
            => Create(ScaleAlias.ModeLocrian);

        public static Scale ModeLocrianBec2
            => Create(ScaleAlias.ModeLocrianBec2);

        public static Scale ModeMixolydianB2B6
            => Create(ScaleAlias.ModeMixolydianB2B6);

        public static Scale ModeAltered
            => Create(ScaleAlias.ModeAltered);

        public static Scale ModeLydianAdded
            => Create(ScaleAlias.ModeLydianAdded);

        public static Scale ModeDiminishedReverse
            => Create(ScaleAlias.ModeDiminishedReverse);

        public static Scale ModeDiminished
            => Create(ScaleAlias.ModeDiminished);
    }
}