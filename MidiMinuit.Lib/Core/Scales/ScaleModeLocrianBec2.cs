using System;
using System.Collections.Generic;
using MidiMinuit.Lib.Core.Notes;

namespace MidiMinuit.Lib.Core.Scales
{
    public class ScaleModeLocrianBec2 : ScaleBase
    {
        public NoteFondamental Fondamental { get; }

        public NoteSecondMajor SecondMajor { get; }

        public NoteThirdMinor ThirdMinor { get; }

        public NoteFourthPerfect FourthPerfect { get; }

        public NoteFifthDiminished FifthDiminished { get; }

        public NoteSixthMinor SixthMinor { get; }

        public NoteSeventhMinor SeventhMinor { get; }

        public ScaleModeLocrianBec2(Note key)
            : base(ScaleTypeEnum.ModeLocrianBec2)
        {
            // mode locrien béc2 : T 2M 3m 4j b5 6m 7m
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            var i = key.Interval;
            Fondamental = i.Fondamental;
            SecondMajor = i.SecondMajor;
            ThirdMinor = i.ThirdMinor;
            FourthPerfect = i.FourthPerfect;
            FifthDiminished = i.FifthDiminished;
            SixthMinor = i.SixthMinor;
            SeventhMinor = i.SeventhMinor;
        }

        public override List<NoteQuality> Notes
            => new List<NoteQuality>
            {
                Fondamental,
                SecondMajor,
                ThirdMinor,
                FourthPerfect,
                FifthDiminished,
                SixthMinor,
                SeventhMinor
            };

        public override string Name
            => $"Mode Locrian Bec2";

        public override string ToString()
        {
            return Name;
        }
    }
}