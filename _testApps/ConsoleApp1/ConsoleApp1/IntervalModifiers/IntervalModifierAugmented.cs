namespace ConsoleApp1.IntervalModifiers
{
    public class IntervalModifierAugmented
        : IntervalModifier
    {
        public override Modifier Modifier { get; }
            = Modifier.Augmented;

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