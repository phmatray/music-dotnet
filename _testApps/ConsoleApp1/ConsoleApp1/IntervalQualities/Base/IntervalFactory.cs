using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1.IntervalQualities
{
    public class IntervalFactory
    {
        public virtual List<Interval> CreateAllIntervals()
        {
            return Enum.GetValues(typeof(IntervalQuality))
                .Cast<IntervalQuality>()
                .Select(CreateInterval)
                .ToList();
        }

        public virtual Interval CreateInterval(IntervalQuality intervalQuality)
        {
            switch (intervalQuality)
            {
                case IntervalQuality.IntervalPerfectUnison:
                    return new IntervalPerfectUnison();
                case IntervalQuality.IntervalPerfectFourth:
                    return new IntervalPerfectFourth();
                case IntervalQuality.IntervalPerfectFifth:
                    return new IntervalPerfectFifth();
                case IntervalQuality.IntervalPerfectOctave:
                    return new IntervalPerfectOctave();
                case IntervalQuality.IntervalMajorSecond:
                    return new IntervalMajorSecond();
                case IntervalQuality.IntervalMajorThird:
                    return new IntervalMajorThird();
                case IntervalQuality.IntervalMajorSixth:
                    return new IntervalMajorSixth();
                case IntervalQuality.IntervalMajorSeventh:
                    return new IntervalMajorSeventh();
                case IntervalQuality.IntervalMinorSecond:
                    return new IntervalMinorSecond();
                case IntervalQuality.IntervalMinorThird:
                    return new IntervalMinorThird();
                case IntervalQuality.IntervalMinorSixth:
                    return new IntervalMinorSixth();
                case IntervalQuality.IntervalMinorSeventh:
                    return new IntervalMinorSeventh();
                case IntervalQuality.IntervalAugmentedUnison:
                    return new IntervalAugmentedUnison();
                case IntervalQuality.IntervalAugmentedSecond:
                    return new IntervalAugmentedSecond();
                case IntervalQuality.IntervalAugmentedThird:
                    return new IntervalAugmentedThird();
                case IntervalQuality.IntervalAugmentedFourth:
                    return new IntervalAugmentedFourth();
                case IntervalQuality.IntervalAugmentedFifth:
                    return new IntervalAugmentedFifth();
                case IntervalQuality.IntervalAugmentedSixth:
                    return new IntervalAugmentedSixth();
                case IntervalQuality.IntervalAugmentedSeventh:
                    return new IntervalAugmentedSeventh();
                case IntervalQuality.IntervalAugmentedOctave:
                    return new IntervalAugmentedOctave();
                case IntervalQuality.IntervalDiminishedSecond:
                    return new IntervalDiminishedSecond();
                case IntervalQuality.IntervalDiminishedThird:
                    return new IntervalDiminishedThird();
                case IntervalQuality.IntervalDiminishedFourth:
                    return new IntervalDiminishedFourth();
                case IntervalQuality.IntervalDiminishedFifth:
                    return new IntervalDiminishedFifth();
                case IntervalQuality.IntervalDiminishedSixth:
                    return new IntervalDiminishedSixth();
                case IntervalQuality.IntervalDiminishedSeventh:
                    return new IntervalDiminishedSeventh();
                case IntervalQuality.IntervalDiminishedOctave:
                    return new IntervalDiminishedOctave();
                default:
                    throw new ArgumentOutOfRangeException(nameof(intervalQuality), intervalQuality, null);
            }
        }
    }
}