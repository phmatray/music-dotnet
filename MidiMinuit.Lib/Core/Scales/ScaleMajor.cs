using System;
using System.Collections.Generic;
using MidiMinuit.Lib.Core.Notes;

namespace MidiMinuit.Lib.Core.Scales
{
    public class ScaleMajor : ScaleBase
    {
        public NoteFondamental Fondamental { get; }

        public NoteSecondMajor SecondMajor { get; }

        public NoteThirdMajor ThirdMajor { get; }

        public NoteFourthPerfect FourthPerfect { get; }

        public NoteFifthPerfect FifthPerfect { get; }

        public NoteSixthMajor SixthMajor { get; }

        public NoteSeventhMajor SeventhMajor { get; }

        public ScaleMajor(Note key)
            : base(ScaleTypeEnum.Major)
        {
            // gamme majeure : T 2M 3M 4j 5j 6M 7M
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
            SeventhMajor = i.SeventhMajor;
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
                SeventhMajor
            };

        public override string Name
            => $"Major";

        public override string ToString()
        {
            return Name;
        }
    }
}