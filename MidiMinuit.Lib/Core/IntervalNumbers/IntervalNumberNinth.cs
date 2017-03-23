namespace MidiMinuit.Lib.Core.IntervalNumbers
{
    public class IntervalNumberNinth
        : IntervalNumber
    {
        public override IntervalNumberAlias Alias { get; }
            = IntervalNumberAlias.Ninth;

        public override int Value { get; }
            = 9;

        public override string Name { get; }
            = "Ninth";

        public override string Abbreviation { get; }
            = "9th";

        public override IntervalNumber Inverse()
            => new IntervalNumberNinth();

        public override string ToString()
            => Name;

        public override IntervalNumber Clone()
            => MemberwiseClone() as IntervalNumber;
    }
}