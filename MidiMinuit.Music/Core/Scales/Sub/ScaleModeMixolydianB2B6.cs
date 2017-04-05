using System.Collections.Generic;

namespace MidiMinuit.Music.Core
{
    public class ScaleModeMixolydianB2B6
        : Scale
    {
        private Pitch _key;

        /// <summary>
        ///     Gets Mode Mixolydienb2b6 : T 2m 3M 4j 5j 6m 7m
        /// </summary>
        public override ScaleAlias Alias { get; }
            = ScaleAlias.ModeMixolydianB2B6;

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
                SecondMinor = new IntervalMinorSecond(_key);
                ThirdMajor = new IntervalMajorThird(_key);
                FourthPerfect = new IntervalPerfectFourth(_key);
                FifthPerfect = new IntervalPerfectFifth(_key);
                SixthMinor = new IntervalMinorSixth(_key);
                SeventhMinor = new IntervalMinorSeventh(_key);
            }
        }

        public IntervalPerfectUnison Fondamental { get; private set; }

        public IntervalMinorSecond SecondMinor { get; private set; }

        public IntervalMajorThird ThirdMajor { get; private set; }

        public IntervalPerfectFourth FourthPerfect { get; private set; }

        public IntervalPerfectFifth FifthPerfect { get; private set; }

        public IntervalMinorSixth SixthMinor { get; private set; }

        public IntervalMinorSeventh SeventhMinor { get; private set; }

        public override List<Interval> Notes
            => new List<Interval>
            {
                Fondamental,
                SecondMinor,
                ThirdMajor,
                FourthPerfect,
                FifthPerfect,
                SixthMinor,
                SeventhMinor
            };

        public override string Name { get; }
            = "Mode Mixolydian b2b6";

        public override string Details { get; }
            = "T 2m 3M 4j 5j 6m 7m";

        public override string ToString()
            => Name;

        public override Scale Clone()
            => MemberwiseClone() as Scale;
    }
}