using System;
using System.Collections.Generic;
using System.Linq;
using MidiMinuit.Music.Core.Notes;

namespace MidiMinuit.Music.Core.Intervals
{
    public class IntervalFactory
    {
        public virtual List<Interval> CreateAllIntervals(Pitch lowerPitch)
        {
            return Enum.GetValues(typeof(IntervalAlias))
                .Cast<IntervalAlias>()
                .Select(x => CreateInterval(x, lowerPitch))
                .ToList();
        }

        public virtual Interval CreateInterval(IntervalAlias interval, Pitch lowerPitch)
        {
            switch (interval)
            {
                case IntervalAlias.IntervalPerfectUnison:
                    return new IntervalPerfectUnison(lowerPitch);
                case IntervalAlias.IntervalPerfectFourth:
                    return new IntervalPerfectFourth(lowerPitch);
                case IntervalAlias.IntervalPerfectFifth:
                    return new IntervalPerfectFifth(lowerPitch);
                case IntervalAlias.IntervalPerfectOctave:
                    return new IntervalPerfectOctave(lowerPitch);
                case IntervalAlias.IntervalMajorSecond:
                    return new IntervalMajorSecond(lowerPitch);
                case IntervalAlias.IntervalMajorThird:
                    return new IntervalMajorThird(lowerPitch);
                case IntervalAlias.IntervalMajorSixth:
                    return new IntervalMajorSixth(lowerPitch);
                case IntervalAlias.IntervalMajorSeventh:
                    return new IntervalMajorSeventh(lowerPitch);
                case IntervalAlias.IntervalMinorSecond:
                    return new IntervalMinorSecond(lowerPitch);
                case IntervalAlias.IntervalMinorThird:
                    return new IntervalMinorThird(lowerPitch);
                case IntervalAlias.IntervalMinorSixth:
                    return new IntervalMinorSixth(lowerPitch);
                case IntervalAlias.IntervalMinorSeventh:
                    return new IntervalMinorSeventh(lowerPitch);
                case IntervalAlias.IntervalAugmentedUnison:
                    return new IntervalAugmentedUnison(lowerPitch);
                case IntervalAlias.IntervalAugmentedSecond:
                    return new IntervalAugmentedSecond(lowerPitch);
                case IntervalAlias.IntervalAugmentedThird:
                    return new IntervalAugmentedThird(lowerPitch);
                case IntervalAlias.IntervalAugmentedFourth:
                    return new IntervalAugmentedFourth(lowerPitch);
                case IntervalAlias.IntervalAugmentedFifth:
                    return new IntervalAugmentedFifth(lowerPitch);
                case IntervalAlias.IntervalAugmentedSixth:
                    return new IntervalAugmentedSixth(lowerPitch);
                case IntervalAlias.IntervalAugmentedSeventh:
                    return new IntervalAugmentedSeventh(lowerPitch);
                case IntervalAlias.IntervalAugmentedOctave:
                    return new IntervalAugmentedOctave(lowerPitch);
                case IntervalAlias.IntervalDiminishedSecond:
                    return new IntervalDiminishedSecond(lowerPitch);
                case IntervalAlias.IntervalDiminishedThird:
                    return new IntervalDiminishedThird(lowerPitch);
                case IntervalAlias.IntervalDiminishedFourth:
                    return new IntervalDiminishedFourth(lowerPitch);
                case IntervalAlias.IntervalDiminishedFifth:
                    return new IntervalDiminishedFifth(lowerPitch);
                case IntervalAlias.IntervalDiminishedSixth:
                    return new IntervalDiminishedSixth(lowerPitch);
                case IntervalAlias.IntervalDiminishedSeventh:
                    return new IntervalDiminishedSeventh(lowerPitch);
                case IntervalAlias.IntervalDiminishedOctave:
                    return new IntervalDiminishedOctave(lowerPitch);
                case IntervalAlias.IntervalMajorNinth:
                    return new IntervalMajorNinth(lowerPitch);
                case IntervalAlias.IntervalAugmentedEleventh:
                    return new IntervalAugmentedEleventh(lowerPitch);
                default:
                    throw new ArgumentOutOfRangeException(nameof(interval), interval, null);
            }
        }
    }
}