using System.Collections.Generic;

namespace MidiMinuit.Music.Core
{
    public class ScaleModeDorian
        : Scale
    {
        private Pitch _key;

        /// <summary>
        ///     Gets Mode Dorien : T 2M 3m 4j 5j 6M 7m
        /// </summary>
        public override ScaleAlias Alias { get; }
            = ScaleAlias.ModeDorian;

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
                FifthPerfect = new IntervalPerfectFifth(_key);
                SixthMajor = new IntervalMajorSixth(_key);
                SeventhMinor = new IntervalMinorSeventh(_key);
            }
        }

        public IntervalPerfectUnison Fondamental { get; private set; }

        public IntervalMajorSecond SecondMajor { get; private set; }

        public IntervalMinorThird ThirdMinor { get; private set; }

        public IntervalPerfectFourth FourthPerfect { get; private set; }

        public IntervalPerfectFifth FifthPerfect { get; private set; }

        public IntervalMajorSixth SixthMajor { get; private set; }

        public IntervalMinorSeventh SeventhMinor { get; private set; }

        public override List<Interval> Notes
            => new List<Interval>
            {
                Fondamental,
                SecondMajor,
                ThirdMinor,
                FourthPerfect,
                FifthPerfect,
                SixthMajor,
                SeventhMinor
            };

        public override string Name { get; }
            = "Mode Dorian";

        public override string Details { get; }
            = "T 2M 3m 4j 5j 6M 7m";

        public override string ToString()
            => Name;

        public override Scale Clone()
            => MemberwiseClone() as Scale;
    }
}