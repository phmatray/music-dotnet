using System;
using System.Collections.Generic;
using MidiMinuit.Music.Core.Intervals;
using MidiMinuit.Music.Core.Notes;

namespace MidiMinuit.Music.Core.Scales
{
    public class ScaleModeLocrian
        : Scale
    {
        public ScaleModeLocrian(Pitch key)
        {
            // mode locrien : T 2m 3m 4j b5 6m 7m
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            Fondamental = new IntervalPerfectUnison(key);
            SecondMinor = new IntervalMinorSecond(key);
            ThirdMinor = new IntervalMinorThird(key);
            FourthPerfect = new IntervalPerfectFourth(key);
            FifthDiminished = new IntervalDiminishedFifth(key);
            SixthMinor = new IntervalMinorSixth(key);
            SeventhMinor = new IntervalMinorSeventh(key);
        }

        public override ScaleAlias Alias { get; }
            = ScaleAlias.ModeLocrian;

        public IntervalPerfectUnison Fondamental { get; }

        public IntervalMinorSecond SecondMinor { get; }

        public IntervalMinorThird ThirdMinor { get; }

        public IntervalPerfectFourth FourthPerfect { get; }

        public IntervalDiminishedFifth FifthDiminished { get; }

        public IntervalMinorSixth SixthMinor { get; }

        public IntervalMinorSeventh SeventhMinor { get; }

        public override List<Interval> Notes
            => new List<Interval>
            {
                Fondamental,
                SecondMinor,
                ThirdMinor,
                FourthPerfect,
                FifthDiminished,
                SixthMinor,
                SeventhMinor
            };

        public override string Name { get; }
            = "Mode Locrian";

        public override string Details { get; }
            = "T 2m 3m 4j b5 6m 7m";

        public override string ToString()
            => Name;

        public override Scale Clone()
            => MemberwiseClone() as Scale;
    }
}