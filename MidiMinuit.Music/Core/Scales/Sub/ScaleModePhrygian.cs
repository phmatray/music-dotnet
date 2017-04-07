using System.Collections.Generic;

namespace MidiMinuit.Music.Core
{
    public class ScaleModePhrygian
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
                MinorThird = new IntervalMinorThird(_key);
                PerfectFourth = new IntervalPerfectFourth(_key);
                PerfectFifth = new IntervalPerfectFifth(_key);
                MinorSixth = new IntervalMinorSixth(_key);
                MinorSeventh = new IntervalMinorSeventh(_key);
            }
        }

        /// <summary>
        ///     Gets Mode Phrygien : T 2m 3m 4j 5j 6m 7m
        /// </summary>
        public override ScaleAlias Alias { get; }
            = ScaleAlias.ModePhrygian;

        public override List<Interval> Intervals
            => new List<Interval>
            {
                Fondamental,
                MinorSecond,
                MinorThird,
                PerfectFourth,
                PerfectFifth,
                MinorSixth,
                MinorSeventh
            };

        public override string Name { get; }
            = "Mode Phrygian";

        public override string ToString()
            => Name;
    }
}