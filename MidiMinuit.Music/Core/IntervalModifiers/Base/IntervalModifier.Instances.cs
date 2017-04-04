namespace MidiMinuit.Music.Core.IntervalModifiers
{
    public partial class IntervalModifier
    {
        public static IntervalModifier Perfect
            => Create(IntervalModifierAlias.Perfect);

        public static IntervalModifier Major
            => Create(IntervalModifierAlias.Major);

        public static IntervalModifier Minor
            => Create(IntervalModifierAlias.Minor);

        public static IntervalModifier Augmented
            => Create(IntervalModifierAlias.Augmented);

        public static IntervalModifier Diminished
            => Create(IntervalModifierAlias.Diminished);
    }
}