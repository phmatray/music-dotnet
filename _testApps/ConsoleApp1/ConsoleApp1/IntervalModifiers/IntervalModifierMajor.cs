namespace ConsoleApp1.IntervalModifiers
{
    public class IntervalModifierMajor
        : IntervalModifier
    {
        public override Modifier Modifier { get; }
            = Modifier.Major;

        public override string Name { get; }
            = "Major";

        public override string Abbreviation { get; }
            = "M";

        public override IntervalModifier Inverse()
            => new IntervalModifierMinor();

        public override string ToString()
            => Name;

        public override IntervalModifier Clone()
            => MemberwiseClone() as IntervalModifier;
    }
}