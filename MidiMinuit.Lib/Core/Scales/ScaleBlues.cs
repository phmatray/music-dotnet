using System;
using System.Collections.Generic;
using MidiMinuit.Lib.Core.Intervals;
using MidiMinuit.Lib.Core.Notes;

namespace MidiMinuit.Lib.Core.Scales
{
    public class ScaleBlues : ScaleBase
    {
        public NoteFondamental Fondamental { get; }

        public NoteThirdMinor ThirdMinor { get; }

        public NoteFourthPerfect FourthPerfect { get; }

        public NoteFifthDiminished FifthDiminished { get; }

        public NoteFifthPerfect FifthPerfect { get; }

        public NoteSeventhMinor SeventhMinor { get; }

        public ScaleBlues(Note key)
            : base(ScaleTypeEnum.Blues)
        {
            // gamme blues : T 3m 4j b5 5j 7m
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            var i = key.Interval;
            Fondamental = i.Fondamental;
            ThirdMinor = i.ThirdMinor;
            FourthPerfect = i.FourthPerfect;
            FifthDiminished = i.FifthDiminished;
            FifthPerfect = i.FifthPerfect;
            SeventhMinor = i.SeventhMinor;
        }

        public override List<NoteQuality> Notes
            => new List<NoteQuality>
            {
                Fondamental,
                ThirdMinor,
                FourthPerfect,
                FifthDiminished,
                FifthPerfect,
                SeventhMinor
            };

        public override string Name
            => $"Blues";

        public override string ToString()
        {
            return Name;
        }
    }
}