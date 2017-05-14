namespace OpenJam.Music.Core
{
    public class DiatonicIntervalSecond
        : DiatonicInterval
    {
        public override DiatonicIntervalAlias DiatonicIntervalAlias { get; }
            = DiatonicIntervalAlias.Second;

        public override int Steps { get; }
            = 2;

        public override string Name { get; }
            = "Second";

        public override string Abbreviation { get; }
            = "2nd";

        public override DiatonicInterval Inverse()
            => new DiatonicIntervalSeventh();

        public override string ToString()
            => Name;
    }
}