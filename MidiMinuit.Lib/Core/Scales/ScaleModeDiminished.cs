using System;
using System.Collections.Generic;
using MidiMinuit.Lib.Core.Notes;

namespace MidiMinuit.Lib.Core.Scales
{
    public class ScaleModeDiminished : ScaleBase
    {
        public NoteFondamental Fondamental { get; }

        public NoteSecondMajor SecondMajor { get; }

        public NoteThirdMinor ThirdMinor { get; }

        public NoteFourthPerfect FourthPerfect { get; }

        public NoteEleventhAugmented EleventhAugmented { get; }

        public NoteFifthAugmented FifthAugmented { get; }

        public NoteSixthMajor SixthMajor { get; }

        public NoteSeventhMajor SeventhMajor { get; }

        public ScaleModeDiminished(Note key)
            : base(ScaleTypeEnum.ModeDiminished)
        {
            // mode diminué : T 2M 3m 4j #11 #5 6M 7M
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            var i = key.Interval;
            Fondamental = i.Fondamental;
            SecondMajor = i.SecondMajor;
            ThirdMinor = i.ThirdMinor;
            FourthPerfect = i.FourthPerfect;
            EleventhAugmented = i.EleventhAugmented;
            FifthAugmented = i.FifthAugmented;
            SixthMajor = i.SixthMajor;
            SeventhMajor = i.SeventhMajor;
        }

        public override List<NoteQuality> Notes
            => new List<NoteQuality>
            {
                Fondamental,
                SecondMajor,
                ThirdMinor,
                FourthPerfect,
                EleventhAugmented,
                FifthAugmented,
                SixthMajor,
                SeventhMajor
            };

        public override string Name
            => $"Mode Diminished";

        public override string ToString()
        {
            return Name;
        }
    }
}