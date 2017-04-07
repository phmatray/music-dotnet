namespace MidiMinuit.Music.Core
{
    public class DiatonicIntervalSixth
        : DiatonicInterval
    {
        public override DiatonicIntervalAlias Alias { get; }
            = DiatonicIntervalAlias.Sixth;

        public override int Steps { get; }
            = 6;

        public override string Name { get; }
            = "Sixth";

        public override string Abbreviation { get; }
            = "6th";

        public override DiatonicInterval Inverse()
            => new DiatonicIntervalThird();

        public override string ToString()
            => Name;

        public override DiatonicInterval Clone()
            => MemberwiseClone() as DiatonicInterval;
    }
}