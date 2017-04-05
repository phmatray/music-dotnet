using System;
using System.Collections.Generic;
using System.Linq;

namespace MidiMinuit.Music.Core
{
    public partial class Interval
    {
        public static List<Interval> CreateAll()
        {
            return Enum.GetValues(typeof(IntervalAlias))
                .Cast<IntervalAlias>()
                .Select(Create)
                .ToList();
        }

        public static Interval Create(IntervalAlias interval)
        {
            switch (interval)
            {
                case IntervalAlias.PerfectUnison:
                    return new IntervalPerfectUnison();
                case IntervalAlias.PerfectFourth:
                    return new IntervalPerfectFourth();
                case IntervalAlias.PerfectFifth:
                    return new IntervalPerfectFifth();
                case IntervalAlias.PerfectOctave:
                    return new IntervalPerfectOctave();
                case IntervalAlias.MajorSecond:
                    return new IntervalMajorSecond();
                case IntervalAlias.MajorThird:
                    return new IntervalMajorThird();
                case IntervalAlias.MajorSixth:
                    return new IntervalMajorSixth();
                case IntervalAlias.MajorSeventh:
                    return new IntervalMajorSeventh();
                case IntervalAlias.MinorSecond:
                    return new IntervalMinorSecond();
                case IntervalAlias.MinorThird:
                    return new IntervalMinorThird();
                case IntervalAlias.MinorSixth:
                    return new IntervalMinorSixth();
                case IntervalAlias.MinorSeventh:
                    return new IntervalMinorSeventh();
                case IntervalAlias.AugmentedUnison:
                    return new IntervalAugmentedUnison();
                case IntervalAlias.AugmentedSecond:
                    return new IntervalAugmentedSecond();
                case IntervalAlias.AugmentedThird:
                    return new IntervalAugmentedThird();
                case IntervalAlias.AugmentedFourth:
                    return new IntervalAugmentedFourth();
                case IntervalAlias.AugmentedFifth:
                    return new IntervalAugmentedFifth();
                case IntervalAlias.AugmentedSixth:
                    return new IntervalAugmentedSixth();
                case IntervalAlias.AugmentedSeventh:
                    return new IntervalAugmentedSeventh();
                case IntervalAlias.AugmentedOctave:
                    return new IntervalAugmentedOctave();
                case IntervalAlias.DiminishedSecond:
                    return new IntervalDiminishedSecond();
                case IntervalAlias.DiminishedThird:
                    return new IntervalDiminishedThird();
                case IntervalAlias.DiminishedFourth:
                    return new IntervalDiminishedFourth();
                case IntervalAlias.DiminishedFifth:
                    return new IntervalDiminishedFifth();
                case IntervalAlias.DiminishedSixth:
                    return new IntervalDiminishedSixth();
                case IntervalAlias.DiminishedSeventh:
                    return new IntervalDiminishedSeventh();
                case IntervalAlias.DiminishedOctave:
                    return new IntervalDiminishedOctave();
                case IntervalAlias.MajorNinth:
                    return new IntervalMajorNinth();
                case IntervalAlias.AugmentedEleventh:
                    return new IntervalAugmentedEleventh();
                default:
                    throw new ArgumentOutOfRangeException(nameof(interval), interval, null);
            }
        }
    }
}