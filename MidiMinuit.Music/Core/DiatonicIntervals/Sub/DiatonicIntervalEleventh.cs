namespace MidiMinuit.Music.Core
{
    public class DiatonicIntervalEleventh
        : DiatonicInterval
    {
        public override DiatonicIntervalAlias Alias { get; }
            = DiatonicIntervalAlias.Eleventh;

        public override int Steps { get; }
            = 11;

        public override string Name { get; }
            = "Eleventh";

        public override string Abbreviation { get; }
            = "11th";

        public override DiatonicInterval Inverse()
            => new DiatonicIntervalSecond();

        public override string ToString()
            => Name;

        public override DiatonicInterval Clone()
            => MemberwiseClone() as DiatonicInterval;
    }
}