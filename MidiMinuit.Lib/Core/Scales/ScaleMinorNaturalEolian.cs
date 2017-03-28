namespace MidiMinuit.Lib.Core.Scales
{
    using System;
    using System.Collections.Generic;
    using Intervals;
    using Notes;

    public class ScaleMinorNaturalEolian
        : Scale
    {
        public ScaleMinorNaturalEolian(Note key)
        {
            // gamme mineure naturelle (mode éolien) : T 2M 3m 4j 5j 6m 7m
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
            SeventhMinor = new IntervalMinorSeventh(key);
        }

        public override ScaleAlias Alias { get; }
            = ScaleAlias.MinorNaturalEolian;

        public IntervalPerfectUnison Fondamental { get; }

        public IntervalMajorSecond SecondMajor { get; }

        public IntervalMinorThird ThirdMinor { get; }

        public IntervalPerfectFourth FourthPerfect { get; }

        public IntervalPerfectFifth FifthPerfect { get; }

        public IntervalMinorSixth SixthMinor { get; }

        public IntervalMinorSeventh SeventhMinor { get; }

        public override List<Interval> Notes
            => new List<Interval>
            {
                Fondamental,
                SecondMajor,
                ThirdMinor,
                FourthPerfect,
                FifthPerfect,
                SixthMinor,
                SeventhMinor
            };

        public override string Name { get; }
            = "Minor Natural Eolian";

        public override string Details { get; }
            = "T 2M 3m 4j 5j 6m 7m";

        public override string ToString()
            => Name;

        public override Scale Clone()
            => MemberwiseClone() as Scale;
    }
}