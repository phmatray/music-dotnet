namespace MidiMinuit.Music.Core
{
    public abstract partial class DiatonicInterval
    {
        /*
         * See https://en.wikipedia.org/wiki/Interval_(music)
         */

        public abstract DiatonicIntervalAlias Alias { get; }

        public abstract int Steps { get; }

        public abstract string Name { get; }

        public abstract string Abbreviation { get; }

        public abstract DiatonicInterval Inverse();

        public abstract override string ToString();

        public abstract DiatonicInterval Clone();
    }
}