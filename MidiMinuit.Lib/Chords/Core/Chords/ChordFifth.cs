using System;
using System.Collections.Generic;
using GuitarChords.Lib.Chords.Enum;
using GuitarChords.Lib.Notes;

namespace GuitarChords.Lib.Chords
{
    public class ChordFifth : Chord
    {
        public NoteFondamental Fondamental { get; }
        public NoteFifthPerfect FifthPerfect { get; }

        protected internal ChordFifth(Note fondamental, Note fifthPerfect)
            : base(ChordQuality.Fifth)
        {
            Fondamental = fondamental as NoteFondamental;
            FifthPerfect = fifthPerfect as NoteFifthPerfect;
        }

        public override List<NoteRole> GetNotes()
        {
            return new List<NoteRole> {Fondamental, FifthPerfect};
        }

        public override string GetDescription()
        {
            return "Descrition not added yet.";
        }

        public override string Format()
        {
            return $"Fond: {Fondamental}, 5th: {FifthPerfect}";
        }

        public override string ToString()
        {
            return $"{Fondamental}5";
        }
    }
}