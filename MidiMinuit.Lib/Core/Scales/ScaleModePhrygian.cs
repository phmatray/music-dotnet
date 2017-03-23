namespace MidiMinuit.Lib.Core.Scales
{
    using System;
    using System.Collections.Generic;
    using Intervals;
    using Notes;

    public class ScaleModePhrygian : Scale
    {
        public ScaleModePhrygian(Note key)
        {
            // mode phrygien : T 2m 3m 4j 5j 6m 7m
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            var i = key.Interval;
            Fondamental = i.Fondamental;
            SecondMinor = i.SecondMinor;
            ThirdMinor = i.ThirdMinor;
            FourthPerfect = i.FourthPerfect;
            FifthPerfect = i.FifthPerfect;
            SixthMinor = i.SixthMinor;
            SeventhMinor = i.SeventhMinor;
        }

        public override ScaleAlias Alias { get; }
            = ScaleAlias.ModePhrygian;

        public IntervalPerfectUnison Fondamental { get; }

        public IntervalMinorSecond SecondMinor { get; }

        public IntervalMinorThird ThirdMinor { get; }

        public IntervalPerfectFourth FourthPerfect { get; }

        public IntervalPerfectFifth FifthPerfect { get; }

        public IntervalMinorSixth SixthMinor { get; }

        public IntervalMinorSeventh SeventhMinor { get; }

        public override List<IntervalQuality> Notes
            => new List<IntervalQuality>
            {
                Fondamental,
                SecondMinor,
                ThirdMinor,
                FourthPerfect,
                FifthPerfect,
                SixthMinor,
                SeventhMinor
            };

        public override string Name { get; }
            = "Mode Phrygian";

        public override string Details { get; }
            = "T 2m 3m 4j 5j 6m 7m";

        public override string ToString()
            => Name;

        public override Scale Clone()
            => MemberwiseClone() as Scale;
    }
}