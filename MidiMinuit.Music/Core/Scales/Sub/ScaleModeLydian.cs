using System.Collections.Generic;

namespace MidiMinuit.Music.Core
{
    public class ScaleModeLydian
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
                PerfectFifth = new IntervalPerfectFifth(_key);
                MajorSixth = new IntervalMajorSixth(_key);
                MajorSeventh = new IntervalMajorSeventh(_key);
            }
        }

        /// <summary>
        ///     Gets Mode Lydien : T 2M 3M #11 5j 6M 7M ???
        /// </summary>
        public override ScaleAlias Alias { get; }
            = ScaleAlias.ModeLydian;

        public override List<Interval> Intervals
            => new List<Interval>
            {
                Fondamental,
                MajorSecond,
                MajorThird,
                Eleventh,
                PerfectFifth,
                MajorSixth,
                MajorSeventh
            };

        public override string Name { get; }
            = "Mode Lydian";

        public override string ToString()
            => Name;

        public override Scale Clone()
            => MemberwiseClone() as Scale;
    }
}