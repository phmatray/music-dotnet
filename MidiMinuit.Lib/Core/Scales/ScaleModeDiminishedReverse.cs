namespace MidiMinuit.Lib.Core.Scales
{
    using System;
    using System.Collections.Generic;
    using Intervals;
    using Notes;

    public class ScaleModeDiminishedReverse : Scale
    {
        public ScaleModeDiminishedReverse(Note key)
        {
            // mode diminué inversé : T 2m 3m 3M b5 5j 6M 7m
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
            FifthPerfect = i.FifthPerfect;
            SixthMajor = i.SixthMajor;
            SeventhMinor = i.SeventhMinor;
        }

        public override ScaleAlias Alias { get; }
            = ScaleAlias.ModeDiminishedReverse;

        public IntervalPerfectUnison Fondamental { get; }

        public IntervalMinorSecond SecondMinor { get; }

        public IntervalMinorThird ThirdMinor { get; }

        public IntervalMajorThird ThirdMajor { get; }

        public IntervalDiminishedFifth FifthDiminished { get; }

        public IntervalPerfectFifth FifthPerfect { get; }

        public IntervalMajorSixth SixthMajor { get; }

        public IntervalMinorSeventh SeventhMinor { get; }

        public override List<IntervalQuality> Notes
            => new List<IntervalQuality>
            {
                Fondamental,
                SecondMinor,
                ThirdMinor,
                ThirdMajor,
                FifthDiminished,
                FifthPerfect,
                SixthMajor,
                SeventhMinor
            };

        public override string Name { get; }
            = "Mode Diminished Reverse";

        public override string Details { get; }
            = "T 2m 3m 3M b5 5j 6M 7m";

        public override string ToString()
            => Name;

        public override Scale Clone()
            => MemberwiseClone() as Scale;
    }
}