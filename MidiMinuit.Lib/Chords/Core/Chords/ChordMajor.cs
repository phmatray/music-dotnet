using System;
using System.Collections.Generic;
using GuitarChords.Lib.Chords.Enum;
using GuitarChords.Lib.Notes;

namespace GuitarChords.Lib.Chords
{
    public class ChordMajor : Chord
    {
        public NoteFondamental Fondamental { get; }
        public NoteThirdMajor ThirdMajor { get; }
        public NoteFifthPerfect FifthPerfect { get; }

        protected internal ChordMajor(Note fondamental, Note thirdMajor, Note fifthPerfect)
            : base(ChordQuality.Major)
        {
            Fondamental  = new NoteFondamental(fondamental);
            ThirdMajor   = new NoteThirdMajor(thirdMajor);
            FifthPerfect = new NoteFifthPerfect(fifthPerfect);
        }

        public override List<NoteRole> GetNotes()
        {
            return new List<NoteRole> {Fondamental, ThirdMajor, FifthPerfect};
        }

        public override string GetDescription()
        {
            return "Descrition not added yet.";
        }

        public override string Format()
        {
            return $"Fond: {Fondamental}, 3rd: {ThirdMajor}, 5th: {FifthPerfect}";
        }

        public override string ToString()
        {
            return $"{Fondamental}maj";
        }
    }
}