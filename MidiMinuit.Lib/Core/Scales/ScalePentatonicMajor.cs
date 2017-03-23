namespace MidiMinuit.Lib.Core.Scales
{
    using System;
    using System.Collections.Generic;
    using Intervals;
    using Notes;

    public class ScalePentatonicMajor
        : Scale
    {
        public ScalePentatonicMajor(Note key)
        {
            // gamme pentatonique majeure : T 2M 3M 5j 6M
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            Fondamental = new IntervalPerfectUnison(key);
            SecondMajor = new IntervalMajorSecond(key);
            ThirdMajor = new IntervalMajorThird(key);
            FifthPerfect = new IntervalPerfectFifth(key);
            SixthMajor = new IntervalMajorSixth(key);
        }

        public override ScaleAlias Alias { get; }
            = ScaleAlias.PentatonicMajor;

        public IntervalPerfectUnison Fondamental { get; }

        public IntervalMajorSecond SecondMajor { get; }

        public IntervalMajorThird ThirdMajor { get; }

        public IntervalPerfectFifth FifthPerfect { get; }

        public IntervalMajorSixth SixthMajor { get; }

        public override List<Interval> Notes
            => new List<Interval>
            {
                Fondamental,
                SecondMajor,
                ThirdMajor,
                FifthPerfect,
                SixthMajor
            };

        public override string Name { get; }
            = "Pentatonic Major";

        public override string Details { get; }
            = "T 2M 3M 5j 6M";

        public override string ToString()
            => Name;

        public override Scale Clone()
            => MemberwiseClone() as Scale;
    }
}