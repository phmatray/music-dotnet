using System.Collections.Generic;
using MidiMinuit.Music.Core.Intervals;
using MidiMinuit.Music.Core.Pitches;

namespace MidiMinuit.Music.Core.Scales
{
    public class ScaleModeLydianAdded
        : Scale
    {
        private Pitch _key;

        /// <summary>
        ///     Gets Mode Lydien Augmenté : T 2M 3M #11 #5 6M 7M
        /// </summary>
        public override ScaleAlias Alias { get; }
            = ScaleAlias.ModeLydianAdded;

        public Pitch Key
        {
            get
            {
                return _key;
            }

            set
            {
                _key = value;
                Fondamental = new IntervalPerfectUnison(_key);
                SecondMajor = new IntervalMajorSecond(_key);
                ThirdMajor = new IntervalMajorThird(_key);
                Eleventh = new IntervalAugmentedEleventh(_key);
                FifthAugmented = new IntervalAugmentedFifth(_key);
                SixthMajor = new IntervalMajorSixth(_key);
                SeventhMajor = new IntervalMajorSeventh(_key);
            }
        }

        public IntervalPerfectUnison Fondamental { get; private set; }

        public IntervalMajorSecond SecondMajor { get; private set; }

        public IntervalMajorThird ThirdMajor { get; private set; }

        public IntervalAugmentedEleventh Eleventh { get; private set; }

        public IntervalAugmentedFifth FifthAugmented { get; private set; }

        public IntervalMajorSixth SixthMajor { get; private set; }

        public IntervalMajorSeventh SeventhMajor { get; private set; }

        public override List<Interval> Notes
            => new List<Interval>
            {
                Fondamental,
                SecondMajor,
                ThirdMajor,
                Eleventh,
                FifthAugmented,
                SixthMajor,
                SeventhMajor
            };

        public override string Name { get; }
            = "Mode Lydian Added";

        public override string Details { get; }
            = "T 2M 3M #11 #5 6M 7M";

        public override string ToString()
            => Name;

        public override Scale Clone()
            => MemberwiseClone() as Scale;
    }
}