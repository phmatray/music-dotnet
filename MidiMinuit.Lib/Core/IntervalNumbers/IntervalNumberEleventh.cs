namespace MidiMinuit.Lib.Core.IntervalNumbers
{
    public class IntervalNumberEleventh
        : IntervalNumber
    {
        public override IntervalNumberAlias Alias { get; }
            = IntervalNumberAlias.Eleventh;

        public override int Value { get; }
            = 11;

        public override string Name { get; }
            = "Eleventh";

        public override string Abbreviation { get; }
            = "11th";

        public override IntervalNumber Inverse()
            => new IntervalNumberSecond();

        public override string ToString()
            => Name;

        public override IntervalNumber Clone()
            => MemberwiseClone() as IntervalNumber;
    }
}