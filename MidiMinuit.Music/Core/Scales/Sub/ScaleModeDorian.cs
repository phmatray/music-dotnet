using System.Collections.Generic;

namespace MidiMinuit.Music.Core
{
    public class ScaleModeDorian
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
                MinorSeventh = new IntervalMinorSeventh(_key);
            }
        }

        /// <summary>
        ///     Gets Mode Dorien : T 2M 3m 4j 5j 6M 7m
        /// </summary>
        public override ScaleAlias Alias { get; }
            = ScaleAlias.ModeDorian;

        public override List<Interval> Intervals
            => new List<Interval>
            {
                Fondamental,
                MajorSecond,
                MinorThird,
                PerfectFourth,
                PerfectFifth,
                MajorSixth,
                MinorSeventh
            };

        public override string Name { get; }
            = "Mode Dorian";

        public override string ToString()
            => Name;

        public override Scale Clone()
            => MemberwiseClone() as Scale;
    }
}