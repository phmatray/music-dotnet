namespace MidiMinuit.Lib.Core.Scales
{
    using System;
    using System.Collections.Generic;
    using Intervals;
    using Notes;

    public class ScaleMinorHarmonic
        : Scale
    {
        public ScaleMinorHarmonic(Note key)
        {
            // gamme mineure harmonique : T 2M 3m 4j 5j 6m 7M
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            Fondamental = new IntervalPerfectUnison(key);
            SecondMajor = new IntervalMajorSecond(key);
            ThirdMinor = new IntervalMinorThird(key);
            FourthPerfect = new IntervalPerfectFourth(key);
            FifthPerfect = new IntervalPerfectFifth(key);
            SixthMinor = new IntervalMinorSixth(key);
            SeventhMajor = new IntervalMajorSeventh(key);
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

        public override List<Interval> Notes
            => new List<Interval>
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