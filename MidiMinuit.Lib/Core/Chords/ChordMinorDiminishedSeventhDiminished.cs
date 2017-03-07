using System;
using System.Collections.Generic;
using MidiMinuit.Lib.Core.Notes;

namespace MidiMinuit.Lib.Core.Chords
{
    public class ChordMinorDiminishedSeventhDiminished : ChordBase
    {
        public NoteFondamental Fondamental { get; }

        public NoteThirdMinor ThirdMinor { get; }

        public NoteFifthDiminished FifthDiminished { get; }

        public NoteSeventhDiminished SeventhDiminished { get; }

        public ChordMinorDiminishedSeventhDiminished(Note fondamental)
            : base(ChordQualityEnum.MinorDiminishedSeventhDiminished)
        {
            if (fondamental == null)
            {
                throw new ArgumentNullException(nameof(fondamental));
            }

            var i = fondamental.Interval;
            Fondamental = i.Fondamental;
            ThirdMinor = i.ThirdMinor;
            FifthDiminished = i.FifthDiminished;
            SeventhDiminished = i.SeventhDiminished;
        }

        public override List<NoteQuality> Notes
            => new List<NoteQuality> { Fondamental, ThirdMinor, FifthDiminished, SeventhDiminished };

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