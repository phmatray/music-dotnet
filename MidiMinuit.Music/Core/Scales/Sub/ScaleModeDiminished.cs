using System.Collections.Generic;

namespace MidiMinuit.Music.Core
{
    public class ScaleModeDiminished
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
                Eleventh = new IntervalAugmentedEleventh(_key);
                AugmentedFifth = new IntervalAugmentedFifth(_key);
                MajorSixth = new IntervalMajorSixth(_key);
                MajorSeventh = new IntervalMajorSeventh(_key);
            }
        }

        /// <summary>
        ///     Gets Mode Diminué : T 2M 3m 4j #11 #5 6M 7M
        /// </summary>
        public override ScaleAlias Alias { get; }
            = ScaleAlias.ModeDiminished;

        public override List<Interval> Intervals
            => new List<Interval>
            {
                Fondamental,
                MajorSecond,
                MinorThird,
                PerfectFourth,
                Eleventh,
                AugmentedFifth,
                MajorSixth,
                MajorSeventh
            };

        public override string Name { get; }
            = "Mode Diminished";

        public override string ToString()
            => Name;

        public override Scale Clone()
            => MemberwiseClone() as Scale;
    }
}