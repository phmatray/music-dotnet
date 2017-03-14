using System;
using System.Collections.Generic;
using MidiMinuit.Lib.Core.Intervals;
using MidiMinuit.Lib.Core.Notes;

namespace MidiMinuit.Lib.Core.Scales
{
    public class ScaleModePhrygian : ScaleBase
    {
        public NoteFondamental Fondamental { get; }

        public NoteSecondMinor SecondMinor { get; }

        public NoteThirdMinor ThirdMinor { get; }

        public NoteFourthPerfect FourthPerfect { get; }

        public NoteFifthPerfect FifthPerfect { get; }

        public NoteSixthMinor SixthMinor { get; }

        public NoteSeventhMinor SeventhMinor { get; }

        public ScaleModePhrygian(Note key)
            : base(ScaleTypeEnum.ModePhrygian)
        {
            // mode phrygien : T 2m 3m 4j 5j 6m 7m
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            var i = key.Interval;
            Fondamental = i.Fondamental;
            SecondMinor = i.SecondMinor;
            ThirdMinor = i.ThirdMinor;
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
                ThirdMinor,
                FourthPerfect,
                FifthPerfect,
                SixthMinor,
                SeventhMinor
            };

        public override string Name
            => $"Mode Phrygian";

        public override string ToString()
        {
            return Name;
        }
    }
}