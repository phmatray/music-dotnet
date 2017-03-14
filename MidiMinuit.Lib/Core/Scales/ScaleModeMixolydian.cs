namespace MidiMinuit.Lib.Core.Scales
{
    using System;
    using System.Collections.Generic;
    using MidiMinuit.Lib.Core.Intervals;
    using MidiMinuit.Lib.Core.Notes;

    public class ScaleModeMixolydian : ScaleBase
    {
        public IntervalPerfectUnison Fondamental { get; }

        public IntervalMajorSecond SecondMajor { get; }

        public IntervalMajorThird ThirdMajor { get; }

        public IntervalPerfectFourth FourthPerfect { get; }

        public IntervalPerfectFifth FifthPerfect { get; }

        public IntervalMajorSixth SixthMajor { get; }

        public IntervalMinorSeventh SeventhMinor { get; }

        public ScaleModeMixolydian(Note key)
            : base(ScaleTypeEnum.ModeMixolydian)
        {
            // mode mixolydien : T 2M 3M 4j 5j 6M 7m
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            var i = key.Interval;
            Fondamental = i.Fondamental;
            SecondMajor = i.SecondMajor;
            ThirdMajor = i.ThirdMajor;
            FourthPerfect = i.FourthPerfect;
            FifthPerfect = i.FifthPerfect;
            SixthMajor = i.SixthMajor;
            SeventhMinor = i.SeventhMinor;
        }

        public override List<NoteQuality> Notes
            => new List<NoteQuality>
            {
                Fondamental,
                SecondMajor,
                ThirdMajor,
                FourthPerfect,
                FifthPerfect,
                SixthMajor,
                SeventhMinor
            };

        public override string Name
            => $"Mode Mixolydian";

        public override string ToString()
        {
            return Name;
        }
    }
}