namespace ConsoleApp1.IntervalModifiers
{
    public class IntervalModifierPerfect
        : IntervalModifier
    {
        public override Modifier Modifier { get; }
            = Modifier.Perfect;

        public override string Name { get; }
            = "Perfect";

        public override string Abbreviation { get; }
            = "P";

        public override IntervalModifier Inverse()
            => new IntervalModifierPerfect();

        public override string ToString()
            => Name;

        public override IntervalModifier Clone()
            => MemberwiseClone() as IntervalModifier;
    }
}