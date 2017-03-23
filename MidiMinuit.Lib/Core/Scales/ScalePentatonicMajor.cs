namespace MidiMinuit.Lib.Core.Scales
{
    using System;
    using System.Collections.Generic;
    using Intervals;
    using Notes;

    public class ScalePentatonicMajor : Scale
    {
        public ScalePentatonicMajor(Note key)
        {
            // gamme pentatonique majeure : T 2M 3M 5j 6M
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            var i = key.Interval;
            Fondamental = i.Fondamental;
            SecondMajor = i.SecondMajor;
            ThirdMajor = i.ThirdMajor;
            FifthPerfect = i.FifthPerfect;
            SixthMajor = i.SixthMajor;
        }

        public override ScaleAlias Alias { get; }
            = ScaleAlias.PentatonicMajor;

        public IntervalPerfectUnison Fondamental { get; }

        public IntervalMajorSecond SecondMajor { get; }

        public IntervalMajorThird ThirdMajor { get; }

        public IntervalPerfectFifth FifthPerfect { get; }

        public IntervalMajorSixth SixthMajor { get; }

        public override List<IntervalQuality> Notes
            => new List<IntervalQuality>
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