namespace MidiMinuit.Lib.Core.Scales
{
    using System;
    using System.Collections.Generic;
    using Intervals;
    using Notes;

    public class ScaleModeLydianB7 : Scale
    {
        public ScaleModeLydianB7(Note key)
        {
            // mode lydien b7 : T 2M 3M #11 5j 6M 7m ???
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            var i = key.Interval;
            Fondamental = i.Fondamental;
            SecondMajor = i.SecondMajor;
            ThirdMajor = i.ThirdMajor;
            Eleventh = i.EleventhAugmented;
            FifthPerfect = i.FifthPerfect;
            SixthMajor = i.SixthMajor;
            SeventhMinor = i.SeventhMinor;
        }

        public override ScaleType Quality { get; }
            = ScaleType.ModeLydianB7;

        public IntervalPerfectUnison Fondamental { get; }

        public IntervalMajorSecond SecondMajor { get; }

        public IntervalMajorThird ThirdMajor { get; }

        public IntervalAugmentedEleventh Eleventh { get; }

        public IntervalPerfectFifth FifthPerfect { get; }

        public IntervalMajorSixth SixthMajor { get; }

        public IntervalMinorSeventh SeventhMinor { get; }

        public override List<IntervalQuality> Notes
            => new List<IntervalQuality>
            {
                Fondamental,
                SecondMajor,
                ThirdMajor,
                Eleventh,
                FifthPerfect,
                SixthMajor,
                SeventhMinor
            };

        public override string Name { get; }
            = "Mode Lydian b7";

        public override string Details { get; }
            = "T 2M 3M #11 5j 6M 7m";

        public override string ToString()
            => Name;

        public override Scale Clone()
            => MemberwiseClone() as Scale;
    }
}