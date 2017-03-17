namespace MidiMinuit.Lib.Core.Scales
{
    using System;
    using System.Collections.Generic;
    using Intervals;
    using Notes;

    public class ScaleModeDiminished : Scale
    {
        public ScaleModeDiminished(Note key)
        {
            // mode diminué : T 2M 3m 4j #11 #5 6M 7M
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            var i = key.Interval;
            Fondamental = i.Fondamental;
            SecondMajor = i.SecondMajor;
            ThirdMinor = i.ThirdMinor;
            FourthPerfect = i.FourthPerfect;
            Eleventh = i.EleventhAugmented;
            FifthAugmented = i.FifthAugmented;
            SixthMajor = i.SixthMajor;
            SeventhMajor = i.SeventhMajor;
        }

        public override ScaleType Quality { get; }
            = ScaleType.ModeDiminished;

        public IntervalPerfectUnison Fondamental { get; }

        public IntervalMajorSecond SecondMajor { get; }

        public IntervalMinorThird ThirdMinor { get; }

        public IntervalPerfectFourth FourthPerfect { get; }

        public IntervalAugmentedEleventh Eleventh { get; }

        public IntervalAugmentedFifth FifthAugmented { get; }

        public IntervalMajorSixth SixthMajor { get; }

        public IntervalMajorSeventh SeventhMajor { get; }

        public override List<IntervalQuality> Notes
            => new List<IntervalQuality>
            {
                Fondamental,
                SecondMajor,
                ThirdMinor,
                FourthPerfect,
                Eleventh,
                FifthAugmented,
                SixthMajor,
                SeventhMajor
            };

        public override string Name { get; }
            = "Mode Diminished";

        public override string Details { get; }
            = "T 2M 3m 4j #11 #5 6M 7M";

        public override string ToString()
            => Name;

        public override Scale Clone()
            => MemberwiseClone() as Scale;
    }
}