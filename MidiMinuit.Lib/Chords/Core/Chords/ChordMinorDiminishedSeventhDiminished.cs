using System;
using System.Collections.Generic;
using GuitarChords.Lib.Chords.Enum;
using GuitarChords.Lib.Notes;

namespace GuitarChords.Lib.Chords
{
    public class ChordMinorDiminishedSeventhDiminished : Chord
    {
        public NoteFondamental       Fondamental       { get; }
        public NoteThirdMinor        ThirdMinor        { get; }
        public NoteFifthDiminished   FifthDiminished   { get; }
        public NoteSeventhDiminished SeventhDiminished { get; }

        protected internal ChordMinorDiminishedSeventhDiminished(Note fondamental, Note thirdMinor, Note fifthDiminished, Note seventhDiminished)
            : base(ChordQuality.MinorDiminishedSeventhDiminished)
        {
            Fondamental       = new NoteFondamental      (fondamental      );
            ThirdMinor        = new NoteThirdMinor       (thirdMinor       );
            FifthDiminished   = new NoteFifthDiminished  (fifthDiminished  );
            SeventhDiminished = new NoteSeventhDiminished(seventhDiminished);
        }

        public override List<NoteRole> GetNotes()
        {
            return new List<NoteRole> {Fondamental, ThirdMinor, FifthDiminished, SeventhDiminished};
        }

        public override string GetDescription()
        {
            return "Un accord dim7 est un accord 7 dont toutes les notes ont été diminuées d'un demi-ton (1 case) à l'exception de la fondamentale.";
        }

        public override string Format()
        {
            return $"Fond: {Fondamental}, 3rd min: {ThirdMinor}, 5th b: {FifthDiminished}, 7th dim: {SeventhDiminished}";
        }

        public override string ToString()
        {
            return $"{Fondamental}dim7";
        }
    }
}