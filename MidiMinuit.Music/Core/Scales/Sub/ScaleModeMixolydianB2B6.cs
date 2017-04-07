using System.Collections.Generic;

namespace MidiMinuit.Music.Core
{
    public class ScaleModeMixolydianB2B6
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
                MinorSecond = new IntervalMinorSecond(_key);
                MajorThird = new IntervalMajorThird(_key);
                PerfectFourth = new IntervalPerfectFourth(_key);
                PerfectFifth = new IntervalPerfectFifth(_key);
                MinorSixth = new IntervalMinorSixth(_key);
                MinorSeventh = new IntervalMinorSeventh(_key);
            }
        }

        /// <summary>
        ///     Gets Mode Mixolydienb2b6 : T 2m 3M 4j 5j 6m 7m
        /// </summary>
        public override ScaleAlias Alias { get; }
            = ScaleAlias.ModeMixolydianB2B6;

        public override List<Interval> Intervals
            => new List<Interval>
            {
                Fondamental,
                MinorSecond,
                MajorThird,
                PerfectFourth,
                PerfectFifth,
                MinorSixth,
                MinorSeventh
            };

        public override string Name { get; }
            = "Mode Mixolydian b2b6";

        public override string ToString()
            => Name;
    }
}