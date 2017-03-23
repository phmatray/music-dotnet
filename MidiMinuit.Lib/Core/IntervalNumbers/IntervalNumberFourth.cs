namespace MidiMinuit.Lib.Core.IntervalNumbers
{
    public class IntervalNumberFourth
        : IntervalNumber
    {
        public override IntervalNumberAlias Alias { get; }
            = IntervalNumberAlias.Fourth;

        public override int Value { get; }
            = 4;

        public override string Name { get; }
            = "Fourth";

        public override string Abbreviation { get; }
            = "4th";

        public override IntervalNumber Inverse()
            => new IntervalNumberFifth();

        public override string ToString()
            => Name;

        public override IntervalNumber Clone()
            => MemberwiseClone() as IntervalNumber;
    }
}