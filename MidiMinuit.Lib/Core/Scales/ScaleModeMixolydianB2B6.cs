using System;
using System.Collections.Generic;
using MidiMinuit.Lib.Core.Intervals;
using MidiMinuit.Lib.Core.Notes;

namespace MidiMinuit.Lib.Core.Scales
{
    public class ScaleModeMixolydianB2B6 : ScaleBase
    {
        public NoteFondamental Fondamental { get; }

        public NoteSecondMinor SecondMinor { get; }

        public NoteThirdMajor ThirdMajor { get; }

        public NoteFourthPerfect FourthPerfect { get; }

        public NoteFifthPerfect FifthPerfect { get; }

        public NoteSixthMinor SixthMinor { get; }

        public NoteSeventhMinor SeventhMinor { get; }

        public ScaleModeMixolydianB2B6(Note key)
            : base(ScaleTypeEnum.ModeMixolydianB2B6)
        {
            // mode mixolydienb2b6 : T 2m 3M 4j 5j 6m 7m
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            var i = key.Interval;
            Fondamental = i.Fondamental;
            SecondMinor = i.SecondMinor;
            ThirdMajor = i.ThirdMajor;
            FourthPerfect = i.FourthPerfect;
            FifthPerfect = i.FifthPerfect;
            SixthMinor = i.SixthMinor;
            SeventhMinor = i.SeventhMinor;
        }

        public override List<NoteQuality> Notes
            => new List<NoteQuality>
            {
                Fondamental,
                SecondMinor,
                ThirdMajor,
                FourthPerfect,
                FifthPerfect,
                SixthMinor,
                SeventhMinor
            };

        public override string Name
            => $"Mode Mixolydian b2b6";

        public override string ToString()
        {
            return Name;
        }
    }
}