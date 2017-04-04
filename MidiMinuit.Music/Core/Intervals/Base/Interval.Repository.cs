namespace MidiMinuit.Music.Core.Intervals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public partial class Interval
    {
        internal static List<Interval> CreateAll()
        {
            return Enum.GetValues(typeof(IntervalAlias))
                .Cast<IntervalAlias>()
                .Select(Create)
                .ToList();
        }

        internal static Interval Create(IntervalAlias interval)
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
                case IntervalAlias.IntervalMajorNinth:
                    return new IntervalMajorNinth();
                case IntervalAlias.IntervalAugmentedEleventh:
                    return new IntervalAugmentedEleventh();
                default:
                    throw new ArgumentOutOfRangeException(nameof(interval), interval, null);
            }
        }
    }
}