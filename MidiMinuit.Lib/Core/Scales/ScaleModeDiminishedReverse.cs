using System;
using System.Collections.Generic;
using MidiMinuit.Lib.Core.Intervals;
using MidiMinuit.Lib.Core.Notes;

namespace MidiMinuit.Lib.Core.Scales
{
    public class ScaleModeDiminishedReverse : ScaleBase
    {
        public NoteFondamental Fondamental { get; }

        public NoteSecondMinor SecondMinor { get; }

        public NoteThirdMinor ThirdMinor { get; }

        public NoteThirdMajor ThirdMajor { get; }

        public NoteFifthDiminished FifthDiminished { get; }

        public NoteFifthPerfect FifthPerfect { get; }

        public NoteSixthMajor SixthMajor { get; }

        public NoteSeventhMinor SeventhMinor { get; }

        public ScaleModeDiminishedReverse(Note key)
            : base(ScaleTypeEnum.ModeDiminishedReverse)
        {
            // mode diminué inversé : T 2m 3m 3M b5 5j 6M 7m
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            var i = key.Interval;
            Fondamental = i.Fondamental;
            SecondMinor = i.SecondMinor;
            ThirdMinor = i.ThirdMinor;
            ThirdMajor = i.ThirdMajor;
            FifthDiminished = i.FifthDiminished;
            FifthPerfect = i.FifthPerfect;
            SixthMajor = i.SixthMajor;
            SeventhMinor = i.SeventhMinor;
        }

        public override List<NoteQuality> Notes
            => new List<NoteQuality>
            {
                Fondamental,
                SecondMinor,
                ThirdMinor,
                ThirdMajor,
                FifthDiminished,
                FifthPerfect,
                SixthMajor,
                SeventhMinor
            };

        public override string Name
            => $"Mode Diminished Reverse";

        public override string ToString()
        {
            return Name;
        }
    }
}