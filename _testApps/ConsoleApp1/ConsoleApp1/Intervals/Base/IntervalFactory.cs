using System.Collections.Generic;
using ConsoleApp1.IntervalQualities;

namespace ConsoleApp1.Intervals
{
    using System;
    using System.Linq;
    using MidiMinuit.Lib.Core.Notes;

    public class IntervalFactory
    {
        public virtual List<Interval> CreateAllIntervals(Note lowerNote)
        {
            return Enum.GetValues(typeof(IntervalQuality))
                .Cast<IntervalQuality>()
                .Select(x => CreateInterval(x, lowerNote))
                .ToList();
        }

        public virtual Interval CreateInterval(IntervalQuality quality, Note lowerNote)
        {
            // Si on connait la qualité de l'intervale et la fondamentale, alors on peut déduire la note haute

            switch (quality)
            {
                case IntervalQuality.IntervalPerfectUnison:
                    return new IntervalPerfectUnison(quality, lowerNote);
                case IntervalQuality.IntervalPerfectFourth:
                    //return new IntervalPerfectFourth(quality, lowerNote);
                case IntervalQuality.IntervalPerfectFifth:
                    //return new IntervalPerfectFifth(quality, lowerNote);
                case IntervalQuality.IntervalPerfectOctave:
                    //return new IntervalPerfectOctave(quality, lowerNote);
                case IntervalQuality.IntervalMajorSecond:
                    //return new IntervalMajorSecond(quality, lowerNote);
                case IntervalQuality.IntervalMajorThird:
                    //return new IntervalMajorThird(quality, lowerNote);
                case IntervalQuality.IntervalMajorSixth:
                    //return new IntervalMajorSixth(quality, lowerNote);
                case IntervalQuality.IntervalMajorSeventh:
                    //return new IntervalMajorSeventh(quality, lowerNote);
                case IntervalQuality.IntervalMinorSecond:
                    //return new IntervalMinorSecond(quality, lowerNote);
                case IntervalQuality.IntervalMinorThird:
                    //return new IntervalMinorThird(quality, lowerNote);
                case IntervalQuality.IntervalMinorSixth:
                    //return new IntervalMinorSixth(quality, lowerNote);
                case IntervalQuality.IntervalMinorSeventh:
                    //return new IntervalMinorSeventh(quality, lowerNote);
                case IntervalQuality.IntervalAugmentedUnison:
                    //return new IntervalAugmentedUnison(quality, lowerNote);
                case IntervalQuality.IntervalAugmentedSecond:
                    //return new IntervalAugmentedSecond(quality, lowerNote);
                case IntervalQuality.IntervalAugmentedThird:
                    //return new IntervalAugmentedThird(quality, lowerNote);
                case IntervalQuality.IntervalAugmentedFourth:
                    //return new IntervalAugmentedFourth(quality, lowerNote);
                case IntervalQuality.IntervalAugmentedFifth:
                    //return new IntervalAugmentedFifth(quality, lowerNote);
                case IntervalQuality.IntervalAugmentedSixth:
                    //return new IntervalAugmentedSixth(quality, lowerNote);
                case IntervalQuality.IntervalAugmentedSeventh:
                    //return new IntervalAugmentedSeventh(quality, lowerNote);
                case IntervalQuality.IntervalAugmentedOctave:
                    //return new IntervalAugmentedOctave(quality, lowerNote);
                case IntervalQuality.IntervalDiminishedSecond:
                    //return new IntervalDiminishedSecond(quality, lowerNote);
                case IntervalQuality.IntervalDiminishedThird:
                    //return new IntervalDiminishedThird(quality, lowerNote);
                case IntervalQuality.IntervalDiminishedFourth:
                    //return new IntervalDiminishedFourth(quality, lowerNote);
                case IntervalQuality.IntervalDiminishedFifth:
                    //return new IntervalDiminishedFifth(quality, lowerNote);
                case IntervalQuality.IntervalDiminishedSixth:
                    //return new IntervalDiminishedSixth(quality, lowerNote);
                case IntervalQuality.IntervalDiminishedSeventh:
                    //return new IntervalDiminishedSeventh(quality, lowerNote);
                case IntervalQuality.IntervalDiminishedOctave:
                    //return new IntervalDiminishedOctave(quality, lowerNote);
                default:
                    throw new ArgumentOutOfRangeException(nameof(quality), quality, null);
            }
        }

        ////public virtual Interval CreateInterval(Note lowerNote, Note upperNote)
        ////{
        ////    // Si on connait la qualité de l'intervale et la fondamentale, alors on peut déduire la note haute

        ////}
    }
}