namespace ConsoleApp1.IntervalNumbers
{
    public class IntervalNumberOctave
        : IntervalNumber
    {
        public override Number Number { get; }
            = Number.Octave;

        public override int Value { get; }
            = 8;

        public override string Name { get; }
            = "Octave";

        public override string Abbreviation { get; }
            = "octave";

        public override IntervalNumber Inverse()
            => new IntervalNumberOctave();

        public override string ToString()
            => Name;

        public override IntervalNumber Clone()
            => MemberwiseClone() as IntervalNumber;
    }
}