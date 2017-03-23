namespace MidiMinuit.Lib.Core.Scales
{
    using System;
    using System.Collections.Generic;
    using Intervals;
    using Notes;

    public class ScaleModeAltered : Scale
    {
        public ScaleModeAltered(Note key)
        {
            // mode altéré : T 2m 3m 3M b5 6m 7m
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            var i = key.Interval;
            Fondamental = i.Fondamental;
            SecondMinor = i.SecondMinor;
            ThirdMinor = i.ThirdMinor;
            ThirdMajor = i.ThirdMajor;
            FifthDiminished = i.FifthDiminished;
            SixthMinor = i.SixthMinor;
            SeventhMinor = i.SeventhMinor;
        }

        public override ScaleAlias Alias { get; }
            = ScaleAlias.ModeAltered;

        public IntervalPerfectUnison Fondamental { get; }

        public IntervalMinorSecond SecondMinor { get; }

        public IntervalMinorThird ThirdMinor { get; }

        public IntervalMajorThird ThirdMajor { get; }

        public IntervalDiminishedFifth FifthDiminished { get; }

        public IntervalMinorSixth SixthMinor { get; }

        public IntervalMinorSeventh SeventhMinor { get; }

        public override List<IntervalQuality> Notes
            => new List<IntervalQuality>
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