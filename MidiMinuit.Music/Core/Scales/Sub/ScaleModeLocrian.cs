using System.Collections.Generic;

namespace MidiMinuit.Music.Core
{
    public class ScaleModeLocrian
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
                DiminishedFifth = new IntervalDiminishedFifth(_key);
                MinorSixth = new IntervalMinorSixth(_key);
                MinorSeventh = new IntervalMinorSeventh(_key);
            }
        }

        /// <summary>
        ///     Gets Mode Locrien : T 2m 3m 4j b5 6m 7m
        /// </summary>
        public override ScaleAlias Alias { get; }
            = ScaleAlias.ModeLocrian;

        public override List<Interval> Intervals
            => new List<Interval>
            {
                Fondamental,
                MinorSecond,
                MinorThird,
                PerfectFourth,
                DiminishedFifth,
                MinorSixth,
                MinorSeventh
            };

        public override string Name { get; }
            = "Mode Locrian";

        public override string ToString()
            => Name;

        public override Scale Clone()
            => MemberwiseClone() as Scale;
    }
}