namespace MidiMinuit.Music.Core.IntervalModifiers
{
    public partial class IntervalModifier
    {
        public static IntervalModifierPerfect Perfect
            => new IntervalModifierPerfect();

        public static IntervalModifierMajor Major
            => new IntervalModifierMajor();

        public static IntervalModifierMinor Minor
            => new IntervalModifierMinor();

        public static IntervalModifierAugmented Augmented
            => new IntervalModifierAugmented();

        public static IntervalModifierDiminished Diminished
            => new IntervalModifierDiminished();
    }
}