using System.Collections.Generic;

namespace MidiMinuit.Music.Core
{
    public class ScaleMinorNaturalEolian
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
                MinorThird = new IntervalMinorThird(_key);
                PerfectFourth = new IntervalPerfectFourth(_key);
                PerfectFifth = new IntervalPerfectFifth(_key);
                MinorSixth = new IntervalMinorSixth(_key);
                MinorSeventh = new IntervalMinorSeventh(_key);
            }
        }

        /// <summary>
        ///     Gets Gamme Mineure Naturelle (mode éolien) : T 2M 3m 4j 5j 6m 7m
        /// </summary>
        public override ScaleAlias Alias { get; }
            = ScaleAlias.MinorNaturalEolian;

        public override List<Interval> Intervals
            => new List<Interval>
            {
                Fondamental,
                MajorSecond,
                MinorThird,
                PerfectFourth,
                PerfectFifth,
                MinorSixth,
                MinorSeventh
            };

        public override string Name { get; }
            = "Minor Natural Eolian";

        public override string ToString()
            => Name;
    }
}