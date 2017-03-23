namespace MidiMinuit.Lib.Core.Intervals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Notes;

    public class IntervalFactory
    {
        public virtual List<Interval> CreateAllIntervals(Note lowerNote)
        {
            return Enum.GetValues(typeof(IntervalAlias))
                .Cast<IntervalAlias>()
                .Select(x => CreateInterval(x, lowerNote))
                .ToList();
        }

        public virtual Interval CreateInterval(IntervalAlias interval, Note lowerNote)
        {
            switch (interval)
            {
                case IntervalAlias.IntervalPerfectUnison:
                    return new IntervalPerfectUnison(lowerNote);
                case IntervalAlias.IntervalPerfectFourth:
                    return new IntervalPerfectFourth(lowerNote);
                case IntervalAlias.IntervalPerfectFifth:
                    return new IntervalPerfectFifth(lowerNote);
                case IntervalAlias.IntervalPerfectOctave:
                    return new IntervalPerfectOctave(lowerNote);
                case IntervalAlias.IntervalMajorSecond:
                    return new IntervalMajorSecond(lowerNote);
                case IntervalAlias.IntervalMajorThird:
                    return new IntervalMajorThird(lowerNote);
                case IntervalAlias.IntervalMajorSixth:
                    return new IntervalMajorSixth(lowerNote);
                case IntervalAlias.IntervalMajorSeventh:
                    return new IntervalMajorSeventh(lowerNote);
                case IntervalAlias.IntervalMinorSecond:
                    return new IntervalMinorSecond(lowerNote);
                case IntervalAlias.IntervalMinorThird:
                    return new IntervalMinorThird(lowerNote);
                case IntervalAlias.IntervalMinorSixth:
                    return new IntervalMinorSixth(lowerNote);
                case IntervalAlias.IntervalMinorSeventh:
                    return new IntervalMinorSeventh(lowerNote);
                case IntervalAlias.IntervalAugmentedUnison:
                    return new IntervalAugmentedUnison(lowerNote);
                case IntervalAlias.IntervalAugmentedSecond:
                    return new IntervalAugmentedSecond(lowerNote);
                case IntervalAlias.IntervalAugmentedThird:
                    return new IntervalAugmentedThird(lowerNote);
                case IntervalAlias.IntervalAugmentedFourth:
                    return new IntervalAugmentedFourth(lowerNote);
                case IntervalAlias.IntervalAugmentedFifth:
                    return new IntervalAugmentedFifth(lowerNote);
                case IntervalAlias.IntervalAugmentedSixth:
                    return new IntervalAugmentedSixth(lowerNote);
                case IntervalAlias.IntervalAugmentedSeventh:
                    return new IntervalAugmentedSeventh(lowerNote);
                case IntervalAlias.IntervalAugmentedOctave:
                    return new IntervalAugmentedOctave(lowerNote);
                case IntervalAlias.IntervalDiminishedSecond:
                    return new IntervalDiminishedSecond(lowerNote);
                case IntervalAlias.IntervalDiminishedThird:
                    return new IntervalDiminishedThird(lowerNote);
                case IntervalAlias.IntervalDiminishedFourth:
                    return new IntervalDiminishedFourth(lowerNote);
                case IntervalAlias.IntervalDiminishedFifth:
                    return new IntervalDiminishedFifth(lowerNote);
                case IntervalAlias.IntervalDiminishedSixth:
                    return new IntervalDiminishedSixth(lowerNote);
                case IntervalAlias.IntervalDiminishedSeventh:
                    return new IntervalDiminishedSeventh(lowerNote);
                case IntervalAlias.IntervalDiminishedOctave:
                    return new IntervalDiminishedOctave(lowerNote);
                case IntervalAlias.IntervalMajorNinth:
                    return new IntervalMajorNinth(lowerNote);
                case IntervalAlias.IntervalAugmentedEleventh:
                    return new IntervalAugmentedEleventh(lowerNote);
                default:
                    throw new ArgumentOutOfRangeException(nameof(interval), interval, null);
            }
        }
    }
}