using System.Collections.Generic;

namespace MidiMinuit.Music.Core
{
    public class ScaleMajor
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
                MajorSeventh = new IntervalMajorSeventh(_key);
            }
        }

        /// <summary>
        ///     Gets Gamme Majeure : T 2M 3M 4j 5j 6M 7M
        /// </summary>
        public override ScaleAlias Alias { get; }
            = ScaleAlias.Major;

        public override List<Interval> Intervals
            => new List<Interval>
            {
                Fondamental,
                MajorSecond,
                MajorThird,
                PerfectFourth,
                PerfectFifth,
                MajorSixth,
                MajorSeventh
            };

        public override string Name { get; }
            = "Major";

        public override string ToString()
            => Name;

        public override Scale Clone()
            => MemberwiseClone() as Scale;
    }
}