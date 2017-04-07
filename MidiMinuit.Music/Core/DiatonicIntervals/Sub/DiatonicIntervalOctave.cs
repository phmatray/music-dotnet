namespace MidiMinuit.Music.Core
{
    public class DiatonicIntervalOctave
        : DiatonicInterval
    {
        public override DiatonicIntervalAlias Alias { get; }
            = DiatonicIntervalAlias.Octave;

        public override int Steps { get; }
            = 8;

        public override string Name { get; }
            = "Octave";

        public override string Abbreviation { get; }
            = "octave";

        public override DiatonicInterval Inverse()
            => new DiatonicIntervalOctave();

        public override string ToString()
            => Name;

        public override DiatonicInterval Clone()
            => MemberwiseClone() as DiatonicInterval;
    }
}