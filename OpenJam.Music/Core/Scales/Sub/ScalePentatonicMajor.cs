using System.Collections.Generic;

namespace OpenJam.Music.Core
{
    public class ScalePentatonicMajor
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
                PerfectFifth = new IntervalPerfectFifth(_key);
                MajorSixth = new IntervalMajorSixth(_key);
            }
        }

        /// <summary>
        ///     Gets Gamme Pentatonique Majeure : T 2M 3M 5j 6M
        /// </summary>
        public override ScaleAlias Alias { get; }
            = ScaleAlias.PentatonicMajor;

        public override List<Interval> Intervals
            => new List<Interval>
            {
                Fondamental,
                MajorSecond,
                MajorThird,
                PerfectFifth,
                MajorSixth
            };

        public override string Name { get; }
            = "Pentatonic Major";

        public override string ToString()
            => Name;
    }
}