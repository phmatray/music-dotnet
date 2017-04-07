using System;
using System.Collections.Generic;
using System.Linq;
using MidiMinuit.Music.Tools;

namespace MidiMinuit.Music.Core
{
    public partial class DiatonicInterval
    {
        public static List<DiatonicInterval> CreateAll()
        {
            return Enum.GetValues(typeof(DiatonicIntervalAlias))
                .Cast<DiatonicIntervalAlias>()
                .Select(Create)
                .ToList();
        }

        public static DiatonicInterval Create(DiatonicIntervalAlias step)
        {
            switch (step)
            {
                case DiatonicIntervalAlias.Unison:
                    return new DiatonicIntervalUnison();
                case DiatonicIntervalAlias.Second:
                    return new DiatonicIntervalSecond();
                case DiatonicIntervalAlias.Third:
                    return new DiatonicIntervalThird();
                case DiatonicIntervalAlias.Fourth:
                    return new DiatonicIntervalFourth();
                case DiatonicIntervalAlias.Fifth:
                    return new DiatonicIntervalFifth();
                case DiatonicIntervalAlias.Sixth:
                    return new DiatonicIntervalSixth();
                case DiatonicIntervalAlias.Seventh:
                    return new DiatonicIntervalSeventh();
                case DiatonicIntervalAlias.Octave:
                    return new DiatonicIntervalOctave();
                default:
                    throw new ArgumentOutOfRangeException(nameof(step), step, null);
            }
        }

        public static DiatonicInterval Create(int steps)
        {
            return MusicContext.DiatonicIntervals
                .Single(x => x.Steps == steps);
        }
    }
}