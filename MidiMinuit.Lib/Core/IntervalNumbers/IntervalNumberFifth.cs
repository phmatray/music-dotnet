namespace MidiMinuit.Lib.Core.IntervalNumbers
{
    public class IntervalNumberFifth
        : IntervalNumber
    {
        public override IntervalNumberAlias Alias { get; }
            = IntervalNumberAlias.Fifth;

        public override int Value { get; }
            = 5;

        public override string Name { get; }
            = "Fifth";

        public override string Abbreviation { get; }
            = "5th";

        public override IntervalNumber Inverse()
            => new IntervalNumberFourth();

        public override string ToString()
            => Name;

        public override IntervalNumber Clone()
            => MemberwiseClone() as IntervalNumber;
    }
}