using System.Collections.Generic;
using MidiMinuit.Music.Core.Intervals;
using MidiMinuit.Music.Core.Pitches;

namespace MidiMinuit.Music.Core.Scales
{
    public class ScaleModeAltered
        : Scale
    {
        private Pitch _key;

        /// <summary>
        ///     Gets Mode Altéré : T 2m 3m 3M b5 6m 7m
        /// </summary>
        public override ScaleAlias Alias { get; }
            = ScaleAlias.ModeAltered;

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
                ThirdMinor = new IntervalMinorThird(_key);
                ThirdMajor = new IntervalMajorThird(_key);
                FifthDiminished = new IntervalDiminishedFifth(_key);
                SixthMinor = new IntervalMinorSixth(_key);
                SeventhMinor = new IntervalMinorSeventh(_key);
            }
        }

        public IntervalPerfectUnison Fondamental { get; private set; }

        public IntervalMinorSecond SecondMinor { get; private set; }

        public IntervalMinorThird ThirdMinor { get; private set; }

        public IntervalMajorThird ThirdMajor { get; private set; }

        public IntervalDiminishedFifth FifthDiminished { get; private set; }

        public IntervalMinorSixth SixthMinor { get; private set; }

        public IntervalMinorSeventh SeventhMinor { get; private set; }

        public override List<Interval> Notes
            => new List<Interval>
            {
                Fondamental,
                SecondMinor,
                ThirdMinor,
                ThirdMajor,
                FifthDiminished,
                SixthMinor,
                SeventhMinor
            };

        public override string Name { get; }
            = "Mode Altered";

        public override string Details { get; }
            = "T 2m 3m 3M b5 6m 7m";

        public override string ToString()
            => Name;

        public override Scale Clone()
            => MemberwiseClone() as Scale;
    }
}