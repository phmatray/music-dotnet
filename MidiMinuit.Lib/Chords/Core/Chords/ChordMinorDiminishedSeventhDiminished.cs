using System.Collections.Generic;
using MidiMinuit.Lib.Chords.Core.Chords.Base;
using MidiMinuit.Lib.Chords.Core.Chords.Enum;
using MidiMinuit.Lib.Chords.Core.Notes;
using MidiMinuit.Lib.Chords.Core.Notes.Base;

namespace MidiMinuit.Lib.Chords.Core.Chords
{
    public class ChordMinorDiminishedSeventhDiminished : Chord
    {
        public NoteFondamental Fondamental { get; }

        public NoteThirdMinor ThirdMinor { get; }

        public NoteFifthDiminished FifthDiminished { get; }

        public NoteSeventhDiminished SeventhDiminished { get; }

        protected internal ChordMinorDiminishedSeventhDiminished(
            Note fondamental, Note thirdMinor, Note fifthDiminished, Note seventhDiminished)
            : base(ChordQuality.MinorDiminishedSeventhDiminished)
        {
            Fondamental = new NoteFondamental(fondamental);
            ThirdMinor = new NoteThirdMinor(thirdMinor);
            FifthDiminished = new NoteFifthDiminished(fifthDiminished);
            SeventhDiminished = new NoteSeventhDiminished(seventhDiminished);
        }

        public override List<NoteRole> Notes
            => new List<NoteRole> { Fondamental, ThirdMinor, FifthDiminished, SeventhDiminished };

        public override string Name
            => $"{Fondamental}dim7";

        public override string Details
            => $"Fond. {Fondamental}, 3ʳᵈ min {ThirdMinor}, 5ᵗʰ♭ {FifthDiminished}, 7ᵗʰ dim {SeventhDiminished}";

        public override string Description
            => "Un accord dim7 est un accord 7 dont toutes les notes ont été diminuées d'un demi-ton (1 case) à l'exception de la fondamentale.";

        public override string ToString()
        {
            return Name;
        }
    }
}