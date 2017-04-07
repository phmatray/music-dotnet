namespace MidiMinuit.Music.Core
{
    public class DiatonicIntervalSixth
        : DiatonicInterval
    {
        public override DiatonicIntervalAlias DiatonicIntervalAlias { get; }
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
    }
}