using System.Collections.Generic;

namespace MidiMinuit.Music.Core
{
    public class ScaleModeLydianAdded
        : Scale
    {
        private Pitch _key;

        public override Pitch Key
        {
            get
            {
                return _key;
            }

            set
            {
                _key = value;
                Fondamental = new IntervalPerfectUnison(_key);
                MajorSecond = new IntervalMajorSecond(_key);
                MajorThird = new IntervalMajorThird(_key);
                Eleventh = new IntervalAugmentedEleventh(_key);
                AugmentedFifth = new IntervalAugmentedFifth(_key);
                MajorSixth = new IntervalMajorSixth(_key);
                MajorSeventh = new IntervalMajorSeventh(_key);
            }
        }

        /// <summary>
        ///     Gets Mode Lydien Augmenté : T 2M 3M #11 #5 6M 7M
        /// </summary>
        public override ScaleAlias Alias { get; }
            = ScaleAlias.ModeLydianAdded;

        public override List<Interval> Intervals
            => new List<Interval>
            {
                Fondamental,
                MajorSecond,
                MajorThird,
                Eleventh,
                AugmentedFifth,
                MajorSixth,
                MajorSeventh
            };

        public override string Name { get; }
            = "Mode Lydian Added";

        public override string ToString()
            => Name;
    }
}