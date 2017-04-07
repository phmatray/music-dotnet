using System;

namespace MidiMinuit.Music.Core
{
    public abstract partial class DiatonicInterval
    {
        /*
         * See https://en.wikipedia.org/wiki/Interval_(music)
         */

        public abstract DiatonicIntervalAlias DiatonicIntervalAlias { get; }

        public abstract int Steps { get; }

        public abstract string Name { get; }

        public abstract string Abbreviation { get; }

        public abstract DiatonicInterval Inverse();

        public DiatonicInterval MakeAscending()
        {
            return Create(Math.Abs(Steps));
        }

        public DiatonicInterval MakeDescending()
        {
            return Create(Math.Abs(Steps) * -1);
        }

        public abstract override string ToString();
    }
}