using System;
using System.Collections.Generic;
using GuitarChords.Lib.Chords.Enum;
using GuitarChords.Lib.Notes;

namespace GuitarChords.Lib.Chords
{
    public class ChordMinorSixthMajor : Chord
    {
        public NoteFondamental  Fondamental  { get; }
        public NoteThirdMinor   ThirdMinor   { get; }
        public NoteFifthPerfect FifthPerfect { get; }
        public NoteSixthMajor   SixthMajor   { get; }

        protected internal ChordMinorSixthMajor(Note fondamental, Note thirdMinor, Note fifthPerfect, Note sixthMajor) 
            : base(ChordQuality.MinorSixthMajor)
        {
            Fondamental  = new NoteFondamental (fondamental );
            ThirdMinor   = new NoteThirdMinor  (thirdMinor  );
            FifthPerfect = new NoteFifthPerfect(fifthPerfect);
            SixthMajor   = new NoteSixthMajor  (sixthMajor  );
        }

        public override List<NoteRole> GetNotes()
        {
            return new List<NoteRole> {Fondamental, ThirdMinor, FifthPerfect, SixthMajor};
        }

        public override string GetDescription()
        {
            return "Descrition not added yet.";
        }

        public override string Format()
        {
            return $"Fond: {Fondamental}, 3rd min: {ThirdMinor}, 5th: {FifthPerfect}, 6th maj: {SixthMajor}";
        }

        public override string ToString()
        {
            return $"{Fondamental}min6";
        }
    }
}