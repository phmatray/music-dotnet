namespace MidiMinuit.Music.Core
{
    public class DiatonicIntervalThird
        : DiatonicInterval
    {
        public override DiatonicIntervalAlias DiatonicIntervalAlias { get; }
            = DiatonicIntervalAlias.Third;

        public override int Steps { get; }
            = 3;

        public override string Name { get; }
            = "Third";

        public override string Abbreviation { get; }
            = "3rd";

        public override DiatonicInterval Inverse()
            => new DiatonicIntervalSixth();

        public override string ToString()
            => Name;
    }
}