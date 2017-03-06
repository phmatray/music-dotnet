using System;
using System.Collections.Generic;
using MidiMinuit.Lib.Core.Notes;

namespace MidiMinuit.Lib.Core.Scales
{
    public class ScaleMinorNaturalEolian : ScaleBase
    {
        public NoteFondamental Fondamental { get; set; }

        public NoteSecondMajor SecondMajor { get; set; }

        public NoteThirdMinor ThirdMinor { get; set; }

        public NoteFourthPerfect FourthPerfect { get; set; }

        public NoteFifthPerfect FifthPerfect { get; set; }

        public NoteSixthMinor SixthMinor { get; set; }

        public NoteSeventhMinor SeventhMinor { get; set; }

        public ScaleMinorNaturalEolian(Note key)
            : base(ScaleTypeEnum.MinorNaturalEolian)
        {
            // gamme mineure naturelle (mode éolien) : T 2M 3m 4j 5j 6m 7m
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
            SeventhMinor = i.SeventhMinor;
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
                SeventhMinor
            };

        public override string Name
            => $"Minor Natural Eolian";

        public override string ToString()
        {
            return Name;
        }
    }
}