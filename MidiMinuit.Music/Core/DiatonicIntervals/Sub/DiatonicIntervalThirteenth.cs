namespace MidiMinuit.Music.Core
{
    public class DiatonicIntervalThirteenth
        : DiatonicInterval
    {
        public override DiatonicIntervalAlias DiatonicIntervalAlias { get; }
            = DiatonicIntervalAlias.Thirteenth;

        public override int Steps { get; }
            = 13;

        public override string Name { get; }
            = "Thirteenth";

        public override string Abbreviation { get; }
            = "13th";

        public override DiatonicInterval Inverse()
            => null;

        public override string ToString()
            => Name;
    }
}