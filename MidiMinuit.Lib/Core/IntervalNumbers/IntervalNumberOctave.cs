namespace MidiMinuit.Lib.Core.IntervalNumbers
{
    public class IntervalNumberOctave
        : IntervalNumber
    {
        public override IntervalNumberAlias Alias { get; }
            = IntervalNumberAlias.Octave;

        public override int Order { get; }
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