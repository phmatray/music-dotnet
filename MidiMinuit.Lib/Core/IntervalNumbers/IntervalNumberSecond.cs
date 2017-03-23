namespace MidiMinuit.Lib.Core.IntervalNumbers
{
    public class IntervalNumberSecond
        : IntervalNumber
    {
        public override IntervalNumberAlias Alias { get; }
            = IntervalNumberAlias.Second;

        public override int Value { get; }
            = 2;

        public override string Name { get; }
            = "Second";

        public override string Abbreviation { get; }
            = "2nd";

        public override IntervalNumber Inverse()
            => new IntervalNumberSeventh();

        public override string ToString()
            => Name;

        public override IntervalNumber Clone()
            => MemberwiseClone() as IntervalNumber;
    }
}