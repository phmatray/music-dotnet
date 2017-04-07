namespace MidiMinuit.Music.Core
{
    public class DiatonicIntervalSeventh
        : DiatonicInterval
    {
        public override DiatonicIntervalAlias Alias { get; }
            = DiatonicIntervalAlias.Seventh;

        public override int Steps { get; }
            = 7;

        public override string Name { get; }
            = "Seventh";

        public override string Abbreviation { get; }
            = "7th";

        public override DiatonicInterval Inverse()
            => new DiatonicIntervalSecond();

        public override string ToString()
            => Name;

        public override DiatonicInterval Clone()
            => MemberwiseClone() as DiatonicInterval;
    }
}