using System.Collections.Generic;

namespace MidiMinuit.Music.Core
{
    public class ScalePentatonicMinor
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
                PerfectFifth = new IntervalPerfectFifth(_key);
                MinorSeventh = new IntervalMinorSeventh(_key);
            }
        }

        /// <summary>
        ///     Gets Gamme Pentatonique Mineure : T 3m 4j 5j 7m
        /// </summary>
        public override ScaleAlias Alias { get; }
            = ScaleAlias.PentatonicMinor;

        public override List<Interval> Intervals
            => new List<Interval>
            {
                Fondamental,
                MinorThird,
                PerfectFourth,
                PerfectFifth,
                MinorSeventh
            };

        public override string Name { get; }
            = "Pentatonic Minor";

        public override string ToString()
            => Name;

        public override Scale Clone()
            => MemberwiseClone() as Scale;
    }
}