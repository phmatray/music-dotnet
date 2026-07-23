namespace OpenJam.Music.Core
{
    public class DiatonicIntervalFourth
        : DiatonicInterval
    {
        public override DiatonicIntervalAlias DiatonicIntervalAlias { get; }
            = DiatonicIntervalAlias.Fourth;

        public override int Steps { get; }
            = 4;

        public override string Name { get; }
            = "Fourth";

        public override string Abbreviation { get; }
            = "4th";

        public override DiatonicInterval Inverse()
            => new DiatonicIntervalFifth();

        public override string ToString()
            => Name;
    }
}