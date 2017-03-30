using System;
using System.Collections.Generic;
using MidiMinuit.Music.Core.Intervals;
using MidiMinuit.Music.Core.Notes;

namespace MidiMinuit.Music.Core.Scales
{
    public class ScaleModeLocrianBec2
        : Scale
    {
        public ScaleModeLocrianBec2(Pitch key)
        {
            // mode locrien béc2 : T 2M 3m 4j b5 6m 7m
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            Fondamental = new IntervalPerfectUnison(key);
            SecondMajor = new IntervalMajorSecond(key);
            ThirdMinor = new IntervalMinorThird(key);
            FourthPerfect = new IntervalPerfectFourth(key);
            FifthDiminished = new IntervalDiminishedFifth(key);
            SixthMinor = new IntervalMinorSixth(key);
            SeventhMinor = new IntervalMinorSeventh(key);
        }

        public override ScaleAlias Alias { get; }
            = ScaleAlias.ModeLocrianBec2;

        public IntervalPerfectUnison Fondamental { get; }

        public IntervalMajorSecond SecondMajor { get; }

        public IntervalMinorThird ThirdMinor { get; }

        public IntervalPerfectFourth FourthPerfect { get; }

        public IntervalDiminishedFifth FifthDiminished { get; }

        public IntervalMinorSixth SixthMinor { get; }

        public IntervalMinorSeventh SeventhMinor { get; }

        public override List<Interval> Notes
            => new List<Interval>
            {
                Fondamental,
                SecondMajor,
                ThirdMinor,
                FourthPerfect,
                FifthDiminished,
                SixthMinor,
                SeventhMinor
            };

        public override string Name { get; }
            = "Mode Locrian Bec2";

        public override string Details { get; }
            = "T 2M 3m 4j b5 6m 7m";

        public override string ToString()
            => Name;

        public override Scale Clone()
            => MemberwiseClone() as Scale;
    }
}