namespace MidiMinuit.Music.Core
{
    public class DiatonicIntervalNinth
        : DiatonicInterval
    {
        public override DiatonicIntervalAlias DiatonicIntervalAlias { get; }
            = DiatonicIntervalAlias.Ninth;

        public override int Steps { get; }
            = 9;

        public override string Name { get; }
            = "Ninth";

        public override string Abbreviation { get; }
            = "9th";

        public override DiatonicInterval Inverse()
            => null;

        public override string ToString()
            => Name;
    }
}