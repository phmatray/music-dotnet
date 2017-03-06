using System;
using System.Collections.Generic;
using MidiMinuit.Lib.Core.Notes;

namespace MidiMinuit.Lib.Core.Scales
{
    public class ScaleModeDorian : ScaleBase
    {
        public NoteFondamental Fondamental { get; set; }

        public NoteSecondMajor SecondMajor { get; set; }

        public NoteThirdMinor ThirdMinor { get; set; }

        public NoteFourthPerfect FourthPerfect { get; set; }

        public NoteFifthPerfect FifthPerfect { get; set; }

        public NoteSixthMajor SixthMajor { get; set; }

        public NoteSeventhMinor SeventhMinor { get; set; }

        public ScaleModeDorian(Note key)
            : base(ScaleTypeEnum.ModeDorian)
        {
            // mode dorien : T 2M 3m 4j 5j 6M 7m
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
            SixthMajor = i.SixthMajor;
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
                SixthMajor,
                SeventhMinor
            };

        public override string Name
            => $"Mode Dorian";

        public override string ToString()
        {
            return Name;
        }
    }
}