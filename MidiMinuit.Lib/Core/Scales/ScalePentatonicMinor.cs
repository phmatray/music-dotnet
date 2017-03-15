namespace MidiMinuit.Lib.Core.Scales
{
    using System;
    using System.Collections.Generic;
    using Intervals;
    using Notes;

    public class ScalePentatonicMinor : ScaleBase
    {
        public IntervalPerfectUnison Fondamental { get; }

        public IntervalMinorThird ThirdMinor { get; }

        public IntervalPerfectFourth FourthPerfect { get; }

        public IntervalPerfectFifth FifthPerfect { get; }

        public IntervalMinorSeventh SeventhMinor { get; }

        public ScalePentatonicMinor(Note key)
            : base(ScaleTypeEnum.PentatonicMinor)
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

        public override List<IntervalQuality> Notes
            => new List<IntervalQuality>
            {
                Fondamental,
                ThirdMinor,
                FourthPerfect,
                FifthPerfect,
                SeventhMinor
            };

        public override string Name
            => $"Pentatonic Minor";

        public override string ToString()
        {
            return Name;
        }
    }
}