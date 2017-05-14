namespace OpenJam.Music.Core
{
    public class IntervalModifierMajor
        : IntervalModifier
    {
        public override IntervalModifierAlias Alias { get; }
            = IntervalModifierAlias.Major;

        public override string Name { get; }
            = "Major";

        public override string Abbreviation { get; }
            = "M";

        public override IntervalModifier Inverse()
            => new IntervalModifierMinor();

        public override string ToString()
            => Name;
    }
}