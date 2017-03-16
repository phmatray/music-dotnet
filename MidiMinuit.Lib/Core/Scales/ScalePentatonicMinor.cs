namespace MidiMinuit.Lib.Core.Scales
{
    using System;
    using System.Collections.Generic;
    using Intervals;
    using Notes;

    public class ScalePentatonicMinor : Scale
    {
        public ScalePentatonicMinor(Note key)
        {
            // gamme pentatonique mineure : T 3m 4j 5j 7m
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            var i = key.Interval;
            Fondamental = i.Fondamental;
            ThirdMinor = i.ThirdMinor;
            FourthPerfect = i.FourthPerfect;
            FifthPerfect = i.FifthPerfect;
            SeventhMinor = i.SeventhMinor;
        }

        public override ScaleType Quality { get; }
            = ScaleType.PentatonicMinor;

        public IntervalPerfectUnison Fondamental { get; }

        public IntervalMinorThird ThirdMinor { get; }

        public IntervalPerfectFourth FourthPerfect { get; }

        public IntervalPerfectFifth FifthPerfect { get; }

        public IntervalMinorSeventh SeventhMinor { get; }

        public override List<IntervalQuality> Notes
            => new List<IntervalQuality>
            {
                Fondamental,
                ThirdMinor,
                FourthPerfect,
                FifthPerfect,
                SeventhMinor
            };

        public override string Name { get; }
            = "Pentatonic Minor";

        public override string Details { get; }
            = "T 3m 4j 5j 7m";

        public override string ToString()
            => Name;

        public override Scale Clone()
            => MemberwiseClone() as Scale;
    }
}