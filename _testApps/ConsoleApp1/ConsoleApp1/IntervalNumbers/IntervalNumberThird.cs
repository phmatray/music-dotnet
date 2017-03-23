namespace ConsoleApp1.IntervalNumbers
{
    public class IntervalNumberThird
        : IntervalNumber
    {
        public override IntervalNumberAlias Alias { get; }
            = IntervalNumberAlias.Third;

        public override int Value { get; }
            = 3;

        public override string Name { get; }
            = "Third";

        public override string Abbreviation { get; }
            = "3rd";

        public override IntervalNumber Inverse()
            => new IntervalNumberSixth();

        public override string ToString()
            => Name;

        public override IntervalNumber Clone()
            => MemberwiseClone() as IntervalNumber;
    }
}