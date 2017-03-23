namespace MidiMinuit.Lib.Core.Chords
{
    using System;
    using System.Collections.Generic;
    using Intervals;
    using Notes;

    public class ChordMinorDiminishedSeventhDiminished : Chord
    {
        public ChordMinorDiminishedSeventhDiminished(Note fondamental)
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

        public IntervalPerfectUnison Fondamental { get; }

        public IntervalMinorThird ThirdMinor { get; }

        public IntervalDiminishedFifth FifthDiminished { get; }

        public IntervalDiminishedSeventh SeventhDiminished { get; }

        public override ChordAlias Alias { get; }
            = ChordAlias.MinorDiminishedSeventhDiminished;

        public override string Description { get; }
            = "Un accord dim7 est un accord 7 dont toutes les notes ont été diminuées " +
              "d'un demi-ton (1 case) à l'exception de la fondamentale.";

        public override List<IntervalQuality> Notes
            => new List<IntervalQuality> { Fondamental, ThirdMinor, FifthDiminished, SeventhDiminished };

        public override string Name
            => $"{Fondamental}dim7";

        public override string Details
            => $"Fond. {Fondamental}, 3ʳᵈ min {ThirdMinor}, 5ᵗʰ♭ {FifthDiminished}, 7ᵗʰ dim {SeventhDiminished}";

        public override string ToString()
            => Name;

        public override Chord Clone()
            => MemberwiseClone() as Chord;
    }
}