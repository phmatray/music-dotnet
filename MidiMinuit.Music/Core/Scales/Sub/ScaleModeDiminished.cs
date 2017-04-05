using System.Collections.Generic;

namespace MidiMinuit.Music.Core
{
    public class ScaleModeDiminished
        : Scale
    {
        private Pitch _key;

        /// <summary>
        ///     Gets Mode Diminué : T 2M 3m 4j #11 #5 6M 7M
        /// </summary>
        public override ScaleAlias Alias { get; }
            = ScaleAlias.ModeDiminished;

        public Pitch Key
        {
            get
            {
                return _key;
            }

            set
            {
                _key = value;
                Fondamental = new IntervalPerfectUnison(_key);
                SecondMajor = new IntervalMajorSecond(_key);
                ThirdMinor = new IntervalMinorThird(_key);
                FourthPerfect = new IntervalPerfectFourth(_key);
                Eleventh = new IntervalAugmentedEleventh(_key);
                FifthAugmented = new IntervalAugmentedFifth(_key);
                SixthMajor = new IntervalMajorSixth(_key);
                SeventhMajor = new IntervalMajorSeventh(_key);
            }
        }

        public IntervalPerfectUnison Fondamental { get; private set; }

        public IntervalMajorSecond SecondMajor { get; private set; }

        public IntervalMinorThird ThirdMinor { get; private set; }

        public IntervalPerfectFourth FourthPerfect { get; private set; }

        public IntervalAugmentedEleventh Eleventh { get; private set; }

        public IntervalAugmentedFifth FifthAugmented { get; private set; }

        public IntervalMajorSixth SixthMajor { get; private set; }

        public IntervalMajorSeventh SeventhMajor { get; private set; }

        public override List<Interval> Notes
            => new List<Interval>
            {
                Fondamental,
                SecondMajor,
                ThirdMinor,
                FourthPerfect,
                Eleventh,
                FifthAugmented,
                SixthMajor,
                SeventhMajor
            };

        public override string Name { get; }
            = "Mode Diminished";

        public override string Details { get; }
            = "T 2M 3m 4j #11 #5 6M 7M";

        public override string ToString()
            => Name;

        public override Scale Clone()
            => MemberwiseClone() as Scale;
    }
}