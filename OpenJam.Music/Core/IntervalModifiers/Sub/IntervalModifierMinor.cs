namespace OpenJam.Music.Core
{
    public class IntervalModifierMinor
        : IntervalModifier
    {
        public override IntervalModifierAlias Alias { get; }
            = IntervalModifierAlias.Minor;

        public override string Name { get; }
            = "Minor";

        public override string Abbreviation { get; }
            = "m";

        public override IntervalModifier Inverse()
            => new IntervalModifierMajor();

        public override string ToString()
            => Name;
    }
}