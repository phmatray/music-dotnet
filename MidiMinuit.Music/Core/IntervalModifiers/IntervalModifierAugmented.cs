namespace MidiMinuit.Music.Core.IntervalModifiers
{
    public class IntervalModifierAugmented
        : IntervalModifier
    {
        public override IntervalModifierAlias Alias { get; }
            = IntervalModifierAlias.Augmented;

        public override string Name { get; }
            = "Augmented";

        public override string Abbreviation { get; }
            = "A";

        public override IntervalModifier Inverse()
            => new IntervalModifierDiminished();

        public override string ToString()
            => Name;

        public override IntervalModifier Clone()
            => MemberwiseClone() as IntervalModifier;
    }
}