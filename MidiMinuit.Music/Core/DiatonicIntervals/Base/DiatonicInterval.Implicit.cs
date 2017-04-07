namespace MidiMinuit.Music.Core
{
    public partial class DiatonicInterval
    {
        public static implicit operator DiatonicIntervalAlias(DiatonicInterval diatonicInterval)
            => diatonicInterval.DiatonicIntervalAlias;

        public static implicit operator DiatonicInterval(DiatonicIntervalAlias alias)
            => Create(alias);
    }
}