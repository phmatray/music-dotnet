using System;
using System.Collections.Generic;
using MidiMinuit.Music.Core.Intervals;
using MidiMinuit.Music.Core.Notes;

namespace MidiMinuit.Music.Core.Scales
{
    public class ScaleBlues
        : Scale
    {
        public ScaleBlues(Pitch key)
        {
            // gamme blues : T 3m 4j b5 5j 7m
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            Fondamental = new IntervalPerfectUnison(key);
            ThirdMinor = new IntervalMinorThird(key);
            FourthPerfect = new IntervalPerfectFourth(key);
            FifthDiminished = new IntervalDiminishedFifth(key);
            FifthPerfect = new IntervalPerfectFifth(key);
            SeventhMinor = new IntervalMinorSeventh(key);
        }

        public override ScaleAlias Alias { get; }
            = ScaleAlias.Blues;

        public IntervalPerfectUnison Fondamental { get; }

        public IntervalMinorThird ThirdMinor { get; }

        public IntervalPerfectFourth FourthPerfect { get; }

        public IntervalDiminishedFifth FifthDiminished { get; }

        public IntervalPerfectFifth FifthPerfect { get; }

        public IntervalMinorSeventh SeventhMinor { get; }

        public override List<Interval> Notes
            => new List<Interval>
            {
                Fondamental,
                ThirdMinor,
                FourthPerfect,
                FifthDiminished,
                FifthPerfect,
                SeventhMinor
            };

        public override string Name { get; }
            = "Blues";

        public override string Details { get; }
            = "T 3m 4j b5 5j 7m";

        public override string ToString()
            => Name;

        public override Scale Clone()
            => MemberwiseClone() as Scale;
    }
}