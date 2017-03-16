namespace MidiMinuit.Lib.Core.Scales
{
    using System;
    using System.Collections.Generic;
    using Intervals;
    using Notes;

    public class ScaleMajor : Scale
    {
        public ScaleMajor(Note key)
        {
            // gamme majeure : T 2M 3M 4j 5j 6M 7M
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            var i = key.Interval;
            Fondamental = i.Fondamental;
            SecondMajor = i.SecondMajor;
            ThirdMajor = i.ThirdMajor;
            FourthPerfect = i.FourthPerfect;
            FifthPerfect = i.FifthPerfect;
            SixthMajor = i.SixthMajor;
            SeventhMajor = i.SeventhMajor;
        }

        public override ScaleTypeEnum Quality { get; }
            = ScaleTypeEnum.Major;

        public IntervalPerfectUnison Fondamental { get; }

        public IntervalMajorSecond SecondMajor { get; }

        public IntervalMajorThird ThirdMajor { get; }

        public IntervalPerfectFourth FourthPerfect { get; }

        public IntervalPerfectFifth FifthPerfect { get; }

        public IntervalMajorSixth SixthMajor { get; }

        public IntervalMajorSeventh SeventhMajor { get; }

        public override List<IntervalQuality> Notes
            => new List<IntervalQuality>
            {
                Fondamental,
                SecondMajor,
                ThirdMajor,
                FourthPerfect,
                FifthPerfect,
                SixthMajor,
                SeventhMajor
            };

        public override string Name { get; }
            = "Major";

        public override string Details { get; }
            = "T 2M 3M 4j 5j 6M 7M";

        public override string ToString()
            => Name;

        public override Scale Clone()
            => MemberwiseClone() as Scale;
    }
}