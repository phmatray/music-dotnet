namespace MidiMinuit.Music.Core
{
    public partial class DiatonicInterval
    {
        public static implicit operator DiatonicIntervalAlias(DiatonicInterval diatonicInterval)
            => diatonicInterval.Alias;

        public static implicit operator DiatonicInterval(DiatonicIntervalAlias alias)
            => Create(alias);
    }
}