using System;
using System.Collections.Generic;
using MidiMinuit.Lib.Core.Intervals;
using MidiMinuit.Lib.Core.Notes;

namespace MidiMinuit.Lib.Core.Scales
{
    public class ScaleMinorHarmonic : ScaleBase
    {
        public NoteFondamental Fondamental { get; }

        public NoteSecondMajor SecondMajor { get; }

        public NoteThirdMinor ThirdMinor { get; }

        public NoteFourthPerfect FourthPerfect { get; }

        public NoteFifthPerfect FifthPerfect { get; }

        public NoteSixthMinor SixthMinor { get; }

        public NoteSeventhMajor SeventhMajor { get; }

        public ScaleMinorHarmonic(Note key)
            : base(ScaleTypeEnum.MinorHarmonic)
        {
            // gamme mineure harmonique : T 2M 3m 4j 5j 6m 7M
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            var i = key.Interval;
            Fondamental = i.Fondamental;
            SecondMajor = i.SecondMajor;
            ThirdMinor = i.ThirdMinor;
            FourthPerfect = i.FourthPerfect;
            FifthPerfect = i.FifthPerfect;
            SixthMinor = i.SixthMinor;
            SeventhMajor = i.SeventhMajor;
        }

        public override List<NoteQuality> Notes
            => new List<NoteQuality>
            {
                Fondamental,
                SecondMajor,
                ThirdMinor,
                FourthPerfect,
                FifthPerfect,
                SixthMinor,
                SeventhMajor
            };

        public override string Name
            => $"Minor Harmonic";

        public override string ToString()
        {
            return Name;
        }
    }
}