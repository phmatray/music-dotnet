namespace MidiMinuit.Lib.Core.Scales
{
    using System;
    using System.Collections.Generic;
    using Intervals;
    using Notes;

    public class ScaleModeLydian : Scale
    {
        public ScaleModeLydian(Note key)
        {
            // mode lydien : T 2M 3M #11 5j 6M 7M ???
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
            SeventhMajor = i.SeventhMajor;
        }

        public override ScaleAlias Alias { get; }
            = ScaleAlias.ModeLydian;

        public IntervalPerfectUnison Fondamental { get; }

        public IntervalMajorSecond SecondMajor { get; }

        public IntervalMajorThird ThirdMajor { get; }

        public IntervalAugmentedEleventh Eleventh { get; }

        public IntervalPerfectFifth FifthPerfect { get; }

        public IntervalMajorSixth SixthMajor { get; }

        public IntervalMajorSeventh SeventhMajor { get; }

        public override List<IntervalQuality> Notes
            => new List<IntervalQuality>
            {
                Fondamental,
                SecondMajor,
                ThirdMajor,
                Eleventh,
                FifthPerfect,
                SixthMajor,
                SeventhMajor
            };

        public override string Name { get; }
            = "Mode Lydian";

        public override string Details { get; }
            = "T 2M 3M #11 5j 6M 7M";

        public override string ToString()
            => Name;

        public override Scale Clone()
            => MemberwiseClone() as Scale;
    }
}