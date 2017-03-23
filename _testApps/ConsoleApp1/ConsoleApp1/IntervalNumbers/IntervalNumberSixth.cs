namespace ConsoleApp1.IntervalNumbers
{
    public class IntervalNumberSixth
        : IntervalNumber
    {
        public override IntervalNumberAlias Alias { get; }
            = IntervalNumberAlias.Sixth;

        public override int Value { get; }
            = 6;

        public override string Name { get; }
            = "Sixth";

        public override string Abbreviation { get; }
            = "6th";

        public override IntervalNumber Inverse()
            => new IntervalNumberThird();

        public override string ToString()
            => Name;

        public override IntervalNumber Clone()
            => MemberwiseClone() as IntervalNumber;
    }
}