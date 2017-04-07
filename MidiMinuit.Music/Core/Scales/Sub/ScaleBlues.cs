using System.Collections.Generic;

namespace MidiMinuit.Music.Core
{
    public class ScaleBlues
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
                MinorThird = new IntervalMinorThird(_key);
                PerfectFourth = new IntervalPerfectFourth(_key);
                DiminishedFifth = new IntervalDiminishedFifth(_key);
                PerfectFifth = new IntervalPerfectFifth(_key);
                MinorSeventh = new IntervalMinorSeventh(_key);
            }
        }

        /// <summary>
        ///     Gets Gamme Blues : T 3m 4j b5 5j 7m
        /// </summary>
        public override ScaleAlias Alias { get; }
            = ScaleAlias.Blues;

        public override List<Interval> Intervals
            => new List<Interval>
            {
                Fondamental,
                MinorThird,
                PerfectFourth,
                DiminishedFifth,
                PerfectFifth,
                MinorSeventh
            };

        public override string Name { get; }
            = "Blues";

        public override string ToString()
            => Name;

        public override Scale Clone()
            => MemberwiseClone() as Scale;
    }
}