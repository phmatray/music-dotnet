using System.Collections.Generic;

namespace OpenJam.Music.Core
{
    public class ScaleModeMixolydian
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
                PerfectFourth = new IntervalPerfectFourth(_key);
                PerfectFifth = new IntervalPerfectFifth(_key);
                MajorSixth = new IntervalMajorSixth(_key);
                MinorSeventh = new IntervalMinorSeventh(_key);
            }
        }

        /// <summary>
        ///     Gets Mode Mixolydien : T 2M 3M 4j 5j 6M 7m
        /// </summary>
        public override ScaleAlias Alias { get; }
            = ScaleAlias.ModeMixolydian;

        public override List<Interval> Intervals
            => new List<Interval>
            {
                Fondamental,
                MajorSecond,
                MajorThird,
                PerfectFourth,
                PerfectFifth,
                MajorSixth,
                MinorSeventh
            };

        public override string Name { get; }
            = "Mode Mixolydian";

        public override string ToString()
            => Name;
    }
}