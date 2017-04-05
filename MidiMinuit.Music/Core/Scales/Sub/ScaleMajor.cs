using System.Collections.Generic;

namespace MidiMinuit.Music.Core
{
    public class ScaleMajor
        : Scale
    {
        private Pitch _key;

        /// <summary>
        ///     Gets Gamme Majeure : T 2M 3M 4j 5j 6M 7M
        /// </summary>
        public override ScaleAlias Alias { get; }
            = ScaleAlias.Major;

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
                ThirdMajor = new IntervalMajorThird(_key);
                FourthPerfect = new IntervalPerfectFourth(_key);
                FifthPerfect = new IntervalPerfectFifth(_key);
                SixthMajor = new IntervalMajorSixth(_key);
                SeventhMajor = new IntervalMajorSeventh(_key);
            }
        }

        public IntervalPerfectUnison Fondamental { get; private set; }

        public IntervalMajorSecond SecondMajor { get;  private set; }

        public IntervalMajorThird ThirdMajor { get;  private set; }

        public IntervalPerfectFourth FourthPerfect { get;  private set; }

        public IntervalPerfectFifth FifthPerfect { get;  private set; }

        public IntervalMajorSixth SixthMajor { get;  private set; }

        public IntervalMajorSeventh SeventhMajor { get;  private set; }

        public override List<Interval> Notes
            => new List<Interval>
            {
                Fondamental,
                SecondMajor,
                ThirdMajor,
                FourthPerfect,
                FifthPerfect,
                SixthMajor,
                SeventhMajor
            };

        public override string Name { get; }
            = "Major";

        public override string Details { get; }
            = "T 2M 3M 4j 5j 6M 7M";

        public override string ToString()
            => Name;

        public override Scale Clone()
            => MemberwiseClone() as Scale;
    }
}