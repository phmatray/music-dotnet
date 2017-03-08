using System;
using System.Collections.Generic;
using MidiMinuit.Lib.Core.Notes;

namespace MidiMinuit.Lib.Core.Scales
{
    public class ScaleModeAltered : ScaleBase
    {
        public NoteFondamental Fondamental { get; }

        public NoteSecondMinor SecondMinor { get; }

        public NoteThirdMinor ThirdMinor { get; }

        public NoteThirdMajor ThirdMajor { get; }

        public NoteFifthDiminished FifthDiminished { get; }

        public NoteSixthMinor SixthMinor { get; }

        public NoteSeventhMinor SeventhMinor { get; }

        public ScaleModeAltered(Note key)
            : base(ScaleTypeEnum.ModeAltered)
        {
            // mode altéré : T 2m 3m 3M b5 6m 7m
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
            SixthMinor = i.SixthMinor;
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
                SixthMinor,
                SeventhMinor
            };

        public override string Name
            => $"Mode Altered";

        public override string ToString()
        {
            return Name;
        }
    }
}