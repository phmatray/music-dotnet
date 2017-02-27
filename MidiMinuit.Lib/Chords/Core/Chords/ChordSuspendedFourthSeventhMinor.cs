using System;
using System.Collections.Generic;
using GuitarChords.Lib.Chords.Enum;
using GuitarChords.Lib.Notes;

namespace GuitarChords.Lib.Chords
{
    public class ChordSuspendedFourthSeventhMinor : Chord
    {
        public NoteFondamental   Fondamental   { get; }
        public NoteFourthPerfect FourthPerfect { get; }
        public NoteFifthPerfect  FifthPerfect  { get; }
        public NoteSeventhMinor  SeventhMinor  { get; }

        protected internal ChordSuspendedFourthSeventhMinor(Note fondamental, Note fourthPerfect, Note fifthPerfect, Note seventhMinor)
            : base(ChordQuality.MajorSuspendedFourthSeventhMinor)
        {
            Fondamental   = new NoteFondamental  (fondamental  );
            FourthPerfect = new NoteFourthPerfect(fourthPerfect);
            FifthPerfect  = new NoteFifthPerfect (fifthPerfect );
            SeventhMinor  = new NoteSeventhMinor (seventhMinor );
        }

        public override List<NoteRole> GetNotes()
        {
            return new List<NoteRole> {Fondamental, FourthPerfect, FifthPerfect, SeventhMinor};
        }

        public override string GetDescription()
        {
            return "Descrition not added yet.";
        }

        public override string Format()
        {
            return $"Fond: {Fondamental}, 4th: {FourthPerfect}, 5th: {FifthPerfect}, 7th min: {SeventhMinor}";
        }

        public override string ToString()
        {
            return $"{Fondamental}7sus4";
        }
    }
}