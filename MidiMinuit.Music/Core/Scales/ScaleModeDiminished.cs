using System;
using System.Collections.Generic;
using MidiMinuit.Music.Core.Intervals;
using MidiMinuit.Music.Core.Notes;

namespace MidiMinuit.Music.Core.Scales
{
    public class ScaleModeDiminished
        : Scale
    {
        public ScaleModeDiminished(Pitch key)
        {
            // mode diminué : T 2M 3m 4j #11 #5 6M 7M
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            Fondamental = new IntervalPerfectUnison(key);
            SecondMajor = new IntervalMajorSecond(key);
            ThirdMinor = new IntervalMinorThird(key);
            FourthPerfect = new IntervalPerfectFourth(key);
            Eleventh = new IntervalAugmentedEleventh(key);
            FifthAugmented = new IntervalAugmentedFifth(key);
            SixthMajor = new IntervalMajorSixth(key);
            SeventhMajor = new IntervalMajorSeventh(key);
        }

        public override ScaleAlias Alias { get; }
            = ScaleAlias.ModeDiminished;

        public IntervalPerfectUnison Fondamental { get; }

        public IntervalMajorSecond SecondMajor { get; }

        public IntervalMinorThird ThirdMinor { get; }

        public IntervalPerfectFourth FourthPerfect { get; }

        public IntervalAugmentedEleventh Eleventh { get; }

        public IntervalAugmentedFifth FifthAugmented { get; }

        public IntervalMajorSixth SixthMajor { get; }

        public IntervalMajorSeventh SeventhMajor { get; }

        public override List<Interval> Notes
            => new List<Interval>
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