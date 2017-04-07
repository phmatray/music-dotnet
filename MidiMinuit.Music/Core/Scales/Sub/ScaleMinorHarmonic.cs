using System.Collections.Generic;

namespace MidiMinuit.Music.Core
{
    public class ScaleMinorHarmonic
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
                MajorSeventh = new IntervalMajorSeventh(_key);
            }
        }

        /// <summary>
        ///     Gets Gamme Mineure Harmonique : T 2M 3m 4j 5j 6m 7M
        /// </summary>
        public override ScaleAlias Alias { get; }
            = ScaleAlias.MinorHarmonic;

        public override List<Interval> Intervals
            => new List<Interval>
            {
                Fondamental,
                MajorSecond,
                MinorThird,
                PerfectFourth,
                PerfectFifth,
                MinorSixth,
                MajorSeventh
            };

        public override string Name { get; }
            = "Minor Harmonic";

        public override string ToString()
            => Name;

        public override Scale Clone()
            => MemberwiseClone() as Scale;
    }
}