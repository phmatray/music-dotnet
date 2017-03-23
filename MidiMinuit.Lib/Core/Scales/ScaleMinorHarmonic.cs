namespace MidiMinuit.Lib.Core.Scales
{
    using System;
    using System.Collections.Generic;
    using Intervals;
    using Notes;

    public class ScaleMinorHarmonic : Scale
    {
        public ScaleMinorHarmonic(Note key)
        {
            // gamme mineure harmonique : T 2M 3m 4j 5j 6m 7M
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            var i = key.Interval;
            Fondamental = i.Fondamental;
            SecondMajor = i.SecondMajor;
            ThirdMinor = i.ThirdMinor;
            FourthPerfect = i.FourthPerfect;
            FifthPerfect = i.FifthPerfect;
            SixthMinor = i.SixthMinor;
            SeventhMajor = i.SeventhMajor;
        }

        public override ScaleAlias Alias { get; }
            = ScaleAlias.MinorHarmonic;

        public IntervalPerfectUnison Fondamental { get; }

        public IntervalMajorSecond SecondMajor { get; }

        public IntervalMinorThird ThirdMinor { get; }

        public IntervalPerfectFourth FourthPerfect { get; }

        public IntervalPerfectFifth FifthPerfect { get; }

        public IntervalMinorSixth SixthMinor { get; }

        public IntervalMajorSeventh SeventhMajor { get; }

        public override List<IntervalQuality> Notes
            => new List<IntervalQuality>
            {
                Fondamental,
                SecondMajor,
                ThirdMinor,
                FourthPerfect,
                FifthPerfect,
                SixthMinor,
                SeventhMajor
            };

        public override string Name { get; }
            = "Minor Harmonic";

        public override string Details { get; }
            = "T 2M 3m 4j 5j 6m 7M";

        public override string ToString()
            => Name;

        public override Scale Clone()
            => MemberwiseClone() as Scale;
    }
}