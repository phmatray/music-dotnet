namespace OpenJam.Music.Core
{
    public partial class Scale
    {
        public static ScaleMajor Major
            => new ScaleMajor();

        public static ScaleMinorMelodic MinorMelodic
            => new ScaleMinorMelodic();

        public static ScaleMinorHarmonic MinorHarmonic
            => new ScaleMinorHarmonic();

        public static ScaleMinorNaturalEolian MinorNaturalEolian
            => new ScaleMinorNaturalEolian();

        public static ScaleModeDorian ModeDorian
            => new ScaleModeDorian();

        public static ScaleModeMixolydian ModeMixolydian
            => new ScaleModeMixolydian();

        public static ScaleModeLydian ModeLydian
            => new ScaleModeLydian();

        public static ScaleModeLydianB7 ModeLydianB7
            => new ScaleModeLydianB7();

        public static ScalePentatonicMajor PentatonicMajor
            => new ScalePentatonicMajor();

        public static ScalePentatonicMinor PentatonicMinor
            => new ScalePentatonicMinor();

        public static ScaleBlues Blues
            => new ScaleBlues();

        public static ScaleModePhrygian ModePhrygian
            => new ScaleModePhrygian();

        public static ScaleModeLocrian ModeLocrian
            => new ScaleModeLocrian();

        public static ScaleModeLocrianBec2 ModeLocrianBec2
            => new ScaleModeLocrianBec2();

        public static ScaleModeMixolydianB2B6 ModeMixolydianB2B6
            => new ScaleModeMixolydianB2B6();

        public static ScaleModeAltered ModeAltered
            => new ScaleModeAltered();

        public static ScaleModeLydianAdded ModeLydianAdded
            => new ScaleModeLydianAdded();

        public static ScaleModeDiminishedReverse ModeDiminishedReverse
            => new ScaleModeDiminishedReverse();

        public static ScaleModeDiminished ModeDiminished
            => new ScaleModeDiminished();
    }
}