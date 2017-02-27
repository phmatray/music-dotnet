using System;
using System.Collections.Generic;
using GuitarChords.Lib.Chords.Enum;
using GuitarChords.Lib.Notes;

namespace GuitarChords.Lib.Chords
{
    public class ChordMajorSeventhMajor : Chord
    {
        public NoteFondamental   Fondamental  { get; }
        public NoteThirdMajor    ThirdMajor   { get; }
        public NoteFifthPerfect  FifthPerfect { get; }
        public NoteSeventhMajor  SeventhMajor { get; }

        protected internal ChordMajorSeventhMajor(Note fondamental, Note thirdMajor, Note fifthPerfect, Note seventhMajor)
            : base(ChordQuality.MajorSeventhMajor)
        {
            Fondamental  = new NoteFondamental (fondamental );
            ThirdMajor   = new NoteThirdMajor  (thirdMajor  );
            FifthPerfect = new NoteFifthPerfect(fifthPerfect);
            SeventhMajor = new NoteSeventhMajor(seventhMajor);
        }

        public override List<NoteRole> GetNotes()
        {
            return new List<NoteRole> {Fondamental, ThirdMajor, FifthPerfect, SeventhMajor};
        }

        public override string GetDescription()
        {
            return "Descrition not added yet.";
        }

        public override string Format()
        {
            return $"Fond: {Fondamental}, 3rd maj: {ThirdMajor}, 5th: {FifthPerfect}, 7th maj: {SeventhMajor}";
        }

        public override string ToString()
        {
            return $"{Fondamental}M7";
        }
    }
}