using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1.Intervals
{
    public class IntervalFactory
    {
        public virtual List<Interval> CreateAllIntervals()
        {
            return Enum.GetValues(typeof(IntervalAlias))
                .Cast<IntervalAlias>()
                .Select(CreateInterval)
                .ToList();
        }

        public virtual Interval CreateInterval(IntervalAlias interval)
        {
            switch (interval)
            {
                case IntervalAlias.IntervalPerfectUnison:
                    return new IntervalPerfectUnison();
                case IntervalAlias.IntervalPerfectFourth:
                    return new IntervalPerfectFourth();
                case IntervalAlias.IntervalPerfectFifth:
                    return new IntervalPerfectFifth();
                case IntervalAlias.IntervalPerfectOctave:
                    return new IntervalPerfectOctave();
                case IntervalAlias.IntervalMajorSecond:
                    return new IntervalMajorSecond();
                case IntervalAlias.IntervalMajorThird:
                    return new IntervalMajorThird();
                case IntervalAlias.IntervalMajorSixth:
                    return new IntervalMajorSixth();
                case IntervalAlias.IntervalMajorSeventh:
                    return new IntervalMajorSeventh();
                case IntervalAlias.IntervalMinorSecond:
                    return new IntervalMinorSecond();
                case IntervalAlias.IntervalMinorThird:
                    return new IntervalMinorThird();
                case IntervalAlias.IntervalMinorSixth:
                    return new IntervalMinorSixth();
                case IntervalAlias.IntervalMinorSeventh:
                    return new IntervalMinorSeventh();
                case IntervalAlias.IntervalAugmentedUnison:
                    return new IntervalAugmentedUnison();
                case IntervalAlias.IntervalAugmentedSecond:
                    return new IntervalAugmentedSecond();
                case IntervalAlias.IntervalAugmentedThird:
                    return new IntervalAugmentedThird();
                case IntervalAlias.IntervalAugmentedFourth:
                    return new IntervalAugmentedFourth();
                case IntervalAlias.IntervalAugmentedFifth:
                    return new IntervalAugmentedFifth();
                case IntervalAlias.IntervalAugmentedSixth:
                    return new IntervalAugmentedSixth();
                case IntervalAlias.IntervalAugmentedSeventh:
                    return new IntervalAugmentedSeventh();
                case IntervalAlias.IntervalAugmentedOctave:
                    return new IntervalAugmentedOctave();
                case IntervalAlias.IntervalDiminishedSecond:
                    return new IntervalDiminishedSecond();
                case IntervalAlias.IntervalDiminishedThird:
                    return new IntervalDiminishedThird();
                case IntervalAlias.IntervalDiminishedFourth:
                    return new IntervalDiminishedFourth();
                case IntervalAlias.IntervalDiminishedFifth:
                    return new IntervalDiminishedFifth();
                case IntervalAlias.IntervalDiminishedSixth:
                    return new IntervalDiminishedSixth();
                case IntervalAlias.IntervalDiminishedSeventh:
                    return new IntervalDiminishedSeventh();
                case IntervalAlias.IntervalDiminishedOctave:
                    return new IntervalDiminishedOctave();
                default:
                    throw new ArgumentOutOfRangeException(nameof(interval), interval, null);
            }
        }
    }
}