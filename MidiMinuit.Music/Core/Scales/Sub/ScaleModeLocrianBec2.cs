using System.Collections.Generic;

namespace MidiMinuit.Music.Core
{
    public class ScaleModeLocrianBec2
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
                DiminishedFifth = new IntervalDiminishedFifth(_key);
                MinorSixth = new IntervalMinorSixth(_key);
                MinorSeventh = new IntervalMinorSeventh(_key);
            }
        }

        /// <summary>
        ///     Gets Mode Locrien Béc2 : T 2M 3m 4j b5 6m 7m
        /// </summary>
        public override ScaleAlias Alias { get; }
            = ScaleAlias.ModeLocrianBec2;

        public override List<Interval> Intervals
            => new List<Interval>
            {
                Fondamental,
                MajorSecond,
                MinorThird,
                PerfectFourth,
                DiminishedFifth,
                MinorSixth,
                MinorSeventh
            };

        public override string Name { get; }
            = "Mode Locrian Bec2";

        public override string ToString()
            => Name;

        public override Scale Clone()
            => MemberwiseClone() as Scale;
    }
}