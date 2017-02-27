using System;
using System.Collections.Generic;
using GuitarChords.Lib.Chords.Enum;
using GuitarChords.Lib.Notes;

namespace GuitarChords.Lib.Chords
{
    public class ChordMajorSixthMajor : Chord
    {
        public NoteFondamental   Fondamental  { get; }
        public NoteThirdMajor    ThirdMajor   { get; }
        public NoteFifthPerfect  FifthPerfect { get; }
        public NoteSixthMajor    SixthMajor   { get; }

        protected internal ChordMajorSixthMajor(Note fondamental, Note thirdMajor, Note fifthPerfect, Note sixthMajor)
            : base(ChordQuality.MajorSixthMajor)
        {
            Fondamental  = new NoteFondamental (fondamental );
            ThirdMajor   = new NoteThirdMajor  (thirdMajor  );
            FifthPerfect = new NoteFifthPerfect(fifthPerfect);
            SixthMajor   = new NoteSixthMajor  (sixthMajor  );
        }

        public override List<NoteRole> GetNotes()
        {
            return new List<NoteRole> {Fondamental, ThirdMajor, FifthPerfect, SixthMajor};
        }

        public override string GetDescription()
        {
            return "Descrition not added yet.";
        }

        public override string Format()
        {
            return $"Fond: {Fondamental}, 3rd maj: {ThirdMajor}, 5th: {FifthPerfect}, 6th maj: {SixthMajor}";
        }

        public override string ToString()
        {
            return $"{Fondamental}6";
        }
    }
}