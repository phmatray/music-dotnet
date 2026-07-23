using System.Collections.Generic;

namespace OpenJam.Music.Core
{
    public class ScaleMinorMelodic
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
                MajorSixth = new IntervalMajorSixth(_key);
                MajorSeventh = new IntervalMajorSeventh(_key);
            }
        }

        /// <summary>
        ///     Gets Gamme Mineure Mélodique : T 2M 3m 4j 5j 6M 7M
        /// </summary>
        public override ScaleAlias Alias { get; }
            = ScaleAlias.MinorMelodic;

        public override List<Interval> Intervals
            => new List<Interval>
            {
                Fondamental,
                MajorSecond,
                MinorThird,
                PerfectFourth,
                PerfectFifth,
                MajorSixth,
                MajorSeventh
            };

        public override string Name { get; }
            = "Minor Melodic";

        public override string ToString()
            => Name;
    }
}