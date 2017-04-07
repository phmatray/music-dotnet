using System.Collections.Generic;

namespace MidiMinuit.Music.Core
{
    public class ScaleModeAltered
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
                MajorThird = new IntervalMajorThird(_key);
                DiminishedFifth = new IntervalDiminishedFifth(_key);
                MinorSixth = new IntervalMinorSixth(_key);
                MinorSeventh = new IntervalMinorSeventh(_key);
            }
        }

        /// <summary>
        ///     Gets Mode Altéré : T 2m 3m 3M b5 6m 7m
        /// </summary>
        public override ScaleAlias Alias { get; }
            = ScaleAlias.ModeAltered;

        public override List<Interval> Intervals
            => new List<Interval>
            {
                Fondamental,
                MinorSecond,
                MinorThird,
                MajorThird,
                DiminishedFifth,
                MinorSixth,
                MinorSeventh
            };

        public override string Name { get; }
            = "Mode Altered";

        public override string ToString()
            => Name;
    }
}