using System;
using System.Collections.Generic;
using MidiMinuit.Music.Core.Intervals;
using MidiMinuit.Music.Core.Notes;

namespace MidiMinuit.Music.Core.Chords
{
    public class ChordMinorDiminishedSeventhDiminished
        : Chord
    {
        public ChordMinorDiminishedSeventhDiminished(Pitch fondamental)
        {
            if (fondamental == null)
            {
                throw new ArgumentNullException(nameof(fondamental));
            }

            Fondamental = new IntervalPerfectUnison(fondamental);
            ThirdMinor = new IntervalMinorThird(fondamental);
            FifthDiminished = new IntervalDiminishedFifth(fondamental);
            SeventhDiminished = new IntervalDiminishedSeventh(fondamental);
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

        public override List<Interval> Intervals
            => new List<Interval> { Fondamental, ThirdMinor, FifthDiminished, SeventhDiminished };

        public override string Name
            => $"{Fondamental}dim7";

        public override string ToString()
            => Name;

        public override Chord Clone()
            => MemberwiseClone() as Chord;
    }
}