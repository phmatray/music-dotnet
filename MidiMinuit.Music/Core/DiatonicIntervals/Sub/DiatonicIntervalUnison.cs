namespace MidiMinuit.Music.Core
{
    public class DiatonicIntervalUnison
        : DiatonicInterval
    {
        public override DiatonicIntervalAlias DiatonicIntervalAlias { get; }
            = DiatonicIntervalAlias.Unison;

        public override int Steps { get; }
            = 1;

        public override string Name { get; }
            = "Unison";

        public override string Abbreviation { get; }
            = "unison";
        public override DiatonicInterval Inverse()
            => new DiatonicIntervalUnison();

        public override string ToString()
            => Name;
    }
}