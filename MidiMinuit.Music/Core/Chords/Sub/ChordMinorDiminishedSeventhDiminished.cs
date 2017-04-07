using System.Collections.Generic;

namespace MidiMinuit.Music.Core
{
    public class ChordMinorDiminishedSeventhDiminished
        : Chord
    {
        private Pitch _key;

        public ChordMinorDiminishedSeventhDiminished()
            : this(null)
        {
        }

        public ChordMinorDiminishedSeventhDiminished(Pitch key)
        {
            Key = key;
        }

        public override Pitch Key
        {
            get
            {
                return _key;
            }

            set
            {
                _key = value;
                Fondamental = new IntervalPerfectUnison(_key);
                MinorThird = new IntervalMinorThird(_key);
                DiminishedFifth = new IntervalDiminishedFifth(_key);
                DiminishedSeventh = new IntervalDiminishedSeventh(_key);
            }
        }

        public override ChordAlias Alias { get; }
            = ChordAlias.MinorDiminishedSeventhDiminished;

        public override string Description { get; }
            = "Un accord dim7 est un accord 7 dont toutes les notes ont été diminuées " +
              "d'un demi-ton (1 case) à l'exception de la fondamentale.";

        public override List<Interval> Intervals
            => new List<Interval> { Fondamental, MinorThird, DiminishedFifth, DiminishedSeventh };

        public override string Abbreviation
            => Fondamental?.UpperPitch != null
                ? $"{Fondamental}dim7"
                : null;

        public ChordMinorDiminishedSeventhDiminished SetKey(Pitch key)
        {
            Key = key;
            return this;
        }

        public override string ToString()
            => Abbreviation;

        public override Chord Clone()
            => MemberwiseClone() as Chord;
    }
}