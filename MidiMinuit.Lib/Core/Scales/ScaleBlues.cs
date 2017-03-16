namespace MidiMinuit.Lib.Core.Scales
{
    using System;
    using System.Collections.Generic;
    using Intervals;
    using Notes;

    public class ScaleBlues : Scale
    {
        public ScaleBlues(Note key)
        {
            // gamme blues : T 3m 4j b5 5j 7m
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            var i = key.Interval;
            Fondamental = i.Fondamental;
            ThirdMinor = i.ThirdMinor;
            FourthPerfect = i.FourthPerfect;
            FifthDiminished = i.FifthDiminished;
            FifthPerfect = i.FifthPerfect;
            SeventhMinor = i.SeventhMinor;
        }

        public override ScaleTypeEnum Quality { get; }
            = ScaleTypeEnum.Blues;

        public IntervalPerfectUnison Fondamental { get; }

        public IntervalMinorThird ThirdMinor { get; }

        public IntervalPerfectFourth FourthPerfect { get; }

        public IntervalDiminishedFifth FifthDiminished { get; }

        public IntervalPerfectFifth FifthPerfect { get; }

        public IntervalMinorSeventh SeventhMinor { get; }

        public override List<IntervalQuality> Notes
            => new List<IntervalQuality>
            {
                Fondamental,
                ThirdMinor,
                FourthPerfect,
                FifthDiminished,
                FifthPerfect,
                SeventhMinor
            };

        public override string Name { get; }
            = "Blues";

        public override string Details { get; }
            = "T 3m 4j b5 5j 7m";

        public override string ToString()
            => Name;

        public override Scale Clone()
            => MemberwiseClone() as Scale;
    }
}