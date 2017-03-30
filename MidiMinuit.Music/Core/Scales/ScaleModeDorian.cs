using System;
using System.Collections.Generic;
using MidiMinuit.Music.Core.Intervals;
using MidiMinuit.Music.Core.Notes;

namespace MidiMinuit.Music.Core.Scales
{
    public class ScaleModeDorian
        : Scale
    {
        public ScaleModeDorian(Pitch key)
        {
            // mode dorien : T 2M 3m 4j 5j 6M 7m
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            Fondamental = new IntervalPerfectUnison(key);
            SecondMajor = new IntervalMajorSecond(key);
            ThirdMinor = new IntervalMinorThird(key);
            FourthPerfect = new IntervalPerfectFourth(key);
            FifthPerfect = new IntervalPerfectFifth(key);
            SixthMajor = new IntervalMajorSixth(key);
            SeventhMinor = new IntervalMinorSeventh(key);
        }

        public override ScaleAlias Alias { get; }
            = ScaleAlias.ModeDorian;

        public IntervalPerfectUnison Fondamental { get; }

        public IntervalMajorSecond SecondMajor { get; }

        public IntervalMinorThird ThirdMinor { get; }

        public IntervalPerfectFourth FourthPerfect { get; }

        public IntervalPerfectFifth FifthPerfect { get; }

        public IntervalMajorSixth SixthMajor { get; }

        public IntervalMinorSeventh SeventhMinor { get; }

        public override List<Interval> Notes
            => new List<Interval>
            {
                Fondamental,
                SecondMajor,
                ThirdMinor,
                FourthPerfect,
                FifthPerfect,
                SixthMajor,
                SeventhMinor
            };

        public override string Name { get; }
            = "Mode Dorian";

        public override string Details { get; }
            = "T 2M 3m 4j 5j 6M 7m";

        public override string ToString()
            => Name;

        public override Scale Clone()
            => MemberwiseClone() as Scale;
    }
}