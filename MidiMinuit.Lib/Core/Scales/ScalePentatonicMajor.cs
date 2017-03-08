using System;
using System.Collections.Generic;
using MidiMinuit.Lib.Core.Notes;

namespace MidiMinuit.Lib.Core.Scales
{
    public class ScalePentatonicMajor : ScaleBase
    {
        public NoteFondamental Fondamental { get; }

        public NoteSecondMajor SecondMajor { get; }

        public NoteThirdMajor ThirdMajor { get; }

        public NoteFifthPerfect FifthPerfect { get; }

        public NoteSixthMajor SixthMajor { get; }

        public ScalePentatonicMajor(Note key)
            : base(ScaleTypeEnum.PentatonicMajor)
        {
            // gamme pentatonique majeure : T 2M 3M 5j 6M
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            var i = key.Interval;
            Fondamental = i.Fondamental;
            SecondMajor = i.SecondMajor;
            ThirdMajor = i.ThirdMajor;
            FifthPerfect = i.FifthPerfect;
            SixthMajor = i.SixthMajor;
        }

        public override List<NoteQuality> Notes
            => new List<NoteQuality>
            {
                Fondamental,
                SecondMajor,
                ThirdMajor,
                FifthPerfect,
                SixthMajor
            };

        public override string Name
            => $"Pentatonic Major";

        public override string ToString()
        {
            return Name;
        }
    }
}