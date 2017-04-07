namespace MidiMinuit.Music.Core
{
    public class IntervalModifierPerfect
        : IntervalModifier
    {
        public override IntervalModifierAlias Alias { get; }
            = IntervalModifierAlias.Perfect;

        public override string Name { get; }
            = "Perfect";

        public override string Abbreviation { get; }
            = "P";

        public override IntervalModifier Inverse()
            => new IntervalModifierPerfect();

        public override string ToString()
            => Name;
    }
}