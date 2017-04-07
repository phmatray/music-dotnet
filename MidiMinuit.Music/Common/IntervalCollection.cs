using System.Collections.Generic;
using System.Linq;
using MidiMinuit.Music.Core;

namespace MidiMinuit.Music.Common
{
    public abstract class IntervalCollection
    {
        public abstract string Name { get; }

        public abstract List<Interval> Intervals { get; }

        public abstract Pitch Key { get; set; }

        public IntervalPerfectUnison Fondamental { get; protected set; }

        public IntervalPerfectFourth PerfectFourth { get; protected set; }

        public IntervalPerfectFifth PerfectFifth { get; protected set; }

        public IntervalMajorSecond MajorSecond { get; protected set; }

        public IntervalMajorThird MajorThird { get; protected set; }

        public IntervalMajorSixth MajorSixth { get; protected set; }

        public IntervalMajorSeventh MajorSeventh { get; protected set; }

        public IntervalMinorSecond MinorSecond { get; protected set; }

        public IntervalMinorThird MinorThird { get; protected set; }

        public IntervalMinorSixth MinorSixth { get; protected set; }

        public IntervalMinorSeventh MinorSeventh { get; protected set; }

        public IntervalAugmentedUnison AugmentedUnison { get; protected set; }

        public IntervalAugmentedSecond AugmentedSecond { get; protected set; }

        public IntervalAugmentedThird AugmentedThird { get; protected set; }

        public IntervalAugmentedFourth AugmentedFourth { get; protected set; }

        public IntervalAugmentedFifth AugmentedFifth { get; protected set; }

        public IntervalAugmentedSixth AugmentedSixth { get; protected set; }

        public IntervalAugmentedSeventh AugmentedSeventh { get; protected set; }

        public IntervalAugmentedOctave AugmentedOctave { get; protected set; }

        public IntervalDiminishedSecond DiminishedSecond { get; protected set; }

        public IntervalDiminishedThird DiminishedThird { get; protected set; }

        public IntervalDiminishedFourth DiminishedFourth { get; protected set; }

        public IntervalDiminishedFifth DiminishedFifth { get; protected set; }

        public IntervalDiminishedSixth DiminishedSixth { get; protected set; }

        public IntervalDiminishedSeventh DiminishedSeventh { get; protected set; }

        public IntervalDiminishedOctave DiminishedOctave { get; protected set; }

        public IntervalMajorNinth Ninth { get; protected set; }

        public IntervalAugmentedEleventh Eleventh { get; protected set; }

        public bool HasUpperPitches
            => Intervals.Any(x => x.UpperPitch != null);

        /// <summary>
        ///     Gets notes of the chord.
        /// </summary>
        public List<Pitch> Pitches
            => HasUpperPitches
                ? Intervals
                    .Select(x => x.UpperPitch)
                    .ToList()
                : null;

        /// <summary>
        ///     Gets details of the chord.
        /// </summary>
        public string Details
            => HasUpperPitches
                ? Intervals
                    .Select(x => $"{x.UpperPitch.ToStep()} ({x.Abbreviation})")
                    .Aggregate((current, next) => current + " - " + next)
                : IntervalDetails;

        public string IntervalDetails
            => Intervals?
                .Select(x => x.Abbreviations.First())
                .Aggregate((current, next) => current + " - " + next);

        public string PitchesDetails
            => HasUpperPitches
                ? Intervals?
                    .Select(x => x.UpperPitch.ToStep().ToString())
                    .Aggregate((current, next) => current + " - " + next)
                : null;

        public int ToneCount
            => Intervals.Count;

        public abstract override string ToString();
    }
}