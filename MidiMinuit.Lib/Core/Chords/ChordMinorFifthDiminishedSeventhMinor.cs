using System;
using System.Collections.Generic;
using MidiMinuit.Lib.Core.Notes;

namespace MidiMinuit.Lib.Core.Chords
{
    public class ChordMinorFifthDiminishedSeventhMinor : ChordBase
    {
        public NoteFondamental Fondamental { get; }

        public NoteThirdMinor ThirdMinor { get; }

        public NoteFifthDiminished FifthDiminished { get; }

        public NoteSeventhMinor SeventhMinor { get; }

        public ChordMinorFifthDiminishedSeventhMinor(Note fondamental)
            : base(ChordQualityEnum.MinorFifthDiminishedSeventhMinor)
        {
            if (fondamental == null)
            {
                throw new ArgumentNullException(nameof(fondamental));
            }

            var i = fondamental.Interval;
            Fondamental = i.Fondamental;
            ThirdMinor = i.ThirdMinor;
            FifthDiminished = i.FifthDiminished;
            SeventhMinor = i.SeventhMinor;
        }

        protected internal ChordMinorFifthDiminishedSeventhMinor(Note fondamental, Note thirdMinor, Note fifthDiminished, Note seventhMinor)
            : base(ChordQualityEnum.MinorFifthDiminishedSeventhMinor)
        {
            Fondamental = new NoteFondamental(fondamental);
            ThirdMinor = new NoteThirdMinor(thirdMinor);
            FifthDiminished = new NoteFifthDiminished(fifthDiminished);
            SeventhMinor = new NoteSeventhMinor(seventhMinor);
        }

        public override List<NoteQuality> Notes
            => new List<NoteQuality> { Fondamental, ThirdMinor, FifthDiminished, SeventhMinor };

        public override string Name
            => $"{Fondamental}min7b5";

        public override string Details
            => $"Fond: {Fondamental}, 3rd min: {ThirdMinor}, 5th b: {FifthDiminished}, 7th min: {SeventhMinor}";

        public override string Description
            => "Description not added yet.";

        public override string ToString()
        {
            return Name;
        }
    }
}