using System;
using System.Collections.Generic;
using MidiMinuit.Lib.Core.Notes;

namespace MidiMinuit.Lib.Core.Chords
{
    public class ChordMinorDiminished : ChordBase
    {
        public NoteFondamental Fondamental { get; }

        public NoteThirdMinor ThirdMinor { get; }

        public NoteFifthDiminished FifthDiminished { get; }

        public ChordMinorDiminished(Note fondamental)
            : base(ChordQualityEnum.MinorDiminished)
        {
            if (fondamental == null)
            {
                throw new ArgumentNullException(nameof(fondamental));
            }

            var i = fondamental.Interval;
            Fondamental = i.Fondamental;
            ThirdMinor = i.ThirdMinor;
            FifthDiminished = i.FifthDiminished;
        }

        protected internal ChordMinorDiminished(Note fondamental, Note thirdMinor, Note fifthDiminished)
            : base(ChordQualityEnum.MinorDiminished)
        {
            Fondamental = new NoteFondamental(fondamental);
            ThirdMinor = new NoteThirdMinor(thirdMinor);
            FifthDiminished = new NoteFifthDiminished(fifthDiminished);
        }

        public override List<NoteQuality> Notes
            => new List<NoteQuality> { Fondamental, ThirdMinor, FifthDiminished };

        public override string Name
            => $"{Fondamental}dim";

        public override string Details
            => $"Fond: {Fondamental}, 3rd min: {ThirdMinor}, 5th b: {FifthDiminished}";

        public override string Description
            => "Description not added yet.";

        public override string ToString()
        {
            return Name;
        }
    }
}