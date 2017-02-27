using System;
using System.Collections.Generic;
using GuitarChords.Lib.Chords.Enum;
using GuitarChords.Lib.Notes;

namespace GuitarChords.Lib.Chords
{
    public class ChordMinor : Chord
    {
        public NoteFondamental  Fondamental  { get; }
        public NoteThirdMinor   ThirdMinor   { get; }
        public NoteFifthPerfect FifthPerfect { get; }

        protected internal ChordMinor(Note fondamental, Note thirdMinor, Note fifthPerfect)
            : base(ChordQuality.Minor)
        {
            Fondamental  = new NoteFondamental  (fondamental );
            ThirdMinor   = new NoteThirdMinor   (thirdMinor  );
            FifthPerfect = new NoteFifthPerfect (fifthPerfect);
        }

        public override List<NoteRole> GetNotes()
        {
            return new List<NoteRole> {Fondamental, ThirdMinor, FifthPerfect};
        }

        public override string GetDescription()
        {
            return "Descrition not added yet.";
        }

        public override string Format()
        {
            return $"Fond: {Fondamental}, 3rd min: {ThirdMinor}, 5th: {FifthPerfect}";
        }

        public override string ToString()
        {
            return $"{Fondamental}min";
        }
    }
}