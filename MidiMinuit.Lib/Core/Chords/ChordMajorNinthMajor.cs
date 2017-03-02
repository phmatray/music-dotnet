using System;
using System.Collections.Generic;
using MidiMinuit.Lib.Core.Notes;

namespace MidiMinuit.Lib.Core.Chords
{
    public class ChordMajorNinthMajor : ChordBase
    {
        public NoteFondamental Fondamental { get; }

        public NoteThirdMajor ThirdMajor { get; }

        public NoteFifthPerfect FifthPerfect { get; }

        public NoteNinthMajor NinthMajor { get; }

        public ChordMajorNinthMajor(Note fondamental)
            : base(ChordQualityEnum.MajorNinthMajor)
        {
            if (fondamental == null)
            {
                throw new ArgumentNullException(nameof(fondamental));
            }

            var i = fondamental.Interval;
            Fondamental = i.Fondamental;
            ThirdMajor = i.ThirdMajor;
            FifthPerfect = i.FifthPerfect;
            NinthMajor = i.NinthMajor;
        }

        protected internal ChordMajorNinthMajor(Note fondamental, Note thirdMajor, Note fifthPerfect, Note ninthMajor)
            : base(ChordQualityEnum.MajorNinthMajor)
        {
            Fondamental = new NoteFondamental(fondamental);
            ThirdMajor = new NoteThirdMajor(thirdMajor);
            FifthPerfect = new NoteFifthPerfect(fifthPerfect);
            NinthMajor = new NoteNinthMajor(ninthMajor);
        }

        public override List<NoteQuality> Notes
            => new List<NoteQuality> { Fondamental, ThirdMajor, FifthPerfect, NinthMajor };

        public override string Name
            => $"{Fondamental}add9";

        public override string Details
            => $"Fond: {Fondamental}, 3rd: {ThirdMajor}, 5th: {FifthPerfect}, 9th: {NinthMajor}";

        public override string Description
            => "Description not added yet.";

        public override string ToString()
        {
            return Name;
        }
    }
}