using System;
using System.Collections.Generic;
using GuitarChords.Lib.Chords.Enum;
using GuitarChords.Lib.Notes;

namespace GuitarChords.Lib.Chords
{
    public class ChordMajorNinthMajor : Chord
    {
        public NoteFondamental  Fondamental  { get; }
        public NoteThirdMajor   ThirdMajor   { get; }
        public NoteFifthPerfect FifthPerfect { get; }
        public NoteNinthMajor   NinthMajor   { get; }

        protected internal ChordMajorNinthMajor(Note fondamental, Note thirdMajor, Note fifthPerfect, Note ninthMajor)
            : base(ChordQuality.MajorNinthMajor)
        {
            Fondamental  = new NoteFondamental (fondamental );
            ThirdMajor   = new NoteThirdMajor  (thirdMajor  );
            FifthPerfect = new NoteFifthPerfect(fifthPerfect);
            NinthMajor   = new NoteNinthMajor  (ninthMajor  );
        }

        public override List<NoteRole> GetNotes()
        {
            return new List<NoteRole> {Fondamental, ThirdMajor, FifthPerfect, NinthMajor};
        }

        public override string GetDescription()
        {
            return "Descrition not added yet.";
        }

        public override string Format()
        {
            return $"Fond: {Fondamental}, 3rd: {ThirdMajor}, 5th: {FifthPerfect}, 9th: {NinthMajor}";
        }

        public override string ToString()
        {
            return $"{Fondamental}add9";
        }
    }
}