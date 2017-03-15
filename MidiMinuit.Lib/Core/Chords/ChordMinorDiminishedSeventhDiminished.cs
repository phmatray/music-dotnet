namespace MidiMinuit.Lib.Core.Chords
{
    using System;
    using System.Collections.Generic;
    using MidiMinuit.Lib.Core.Intervals;
    using MidiMinuit.Lib.Core.Notes;

    public class ChordMinorDiminishedSeventhDiminished : ChordBase
    {
        public IntervalPerfectUnison Fondamental { get; }

        public IntervalMinorThird ThirdMinor { get; }

        public IntervalDiminishedFifth FifthDiminished { get; }

        public IntervalDiminishedSeventh SeventhDiminished { get; }

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

        public override List<IntervalQuality> Notes
            => new List<IntervalQuality> { Fondamental, ThirdMinor, FifthDiminished, SeventhDiminished };

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