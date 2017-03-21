namespace ConsoleApp1.IntervalNumbers
{
    public class IntervalNumberSeventh
        : IntervalNumber
    {
        public override Number Number { get; }
            = Number.Seventh;

        public override int Value { get; }
            = 7;

        public override string Name { get; }
            = "Seventh";

        public override string Abbreviation { get; }
            = "7th";

        public override IntervalNumber Inverse()
            => new IntervalNumberSecond();

        public override string ToString()
            => Name;

        public override IntervalNumber Clone()
            => MemberwiseClone() as IntervalNumber;
    }
}