namespace MidiMinuit.Music.Core
{
    public class DiatonicIntervalFifth
        : DiatonicInterval
    {
        public override DiatonicIntervalAlias Alias { get; }
            = DiatonicIntervalAlias.Fifth;

        public override int Steps { get; }
            = 5;

        public override string Name { get; }
            = "Fifth";

        public override string Abbreviation { get; }
            = "5th";

        public override DiatonicInterval Inverse()
            => new DiatonicIntervalFourth();

        public override string ToString()
            => Name;

        public override DiatonicInterval Clone()
            => MemberwiseClone() as DiatonicInterval;
    }
}