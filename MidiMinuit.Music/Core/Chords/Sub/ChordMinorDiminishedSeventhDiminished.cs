using System.Collections.Generic;
using MidiMinuit.Music.Core.Intervals;
using MidiMinuit.Music.Core.Pitches;

namespace MidiMinuit.Music.Core.Chords
{
    public class ChordMinorDiminishedSeventhDiminished
        : Chord
    {
        private Pitch _key;

        public ChordMinorDiminishedSeventhDiminished()
        {
        }

        public ChordMinorDiminishedSeventhDiminished(Pitch key)
        {
            Key = key;
        }

        public Pitch Key
        {
            get
            {
                return _key;
            }

            set
            {
                _key = value;
                Fondamental = new IntervalPerfectUnison(_key);
                ThirdMinor = new IntervalMinorThird(_key);
                FifthDiminished = new IntervalDiminishedFifth(_key);
                SeventhDiminished = new IntervalDiminishedSeventh(_key);
            }
        }

        public IntervalMinorThird ThirdMinor { get; private set; }

        public IntervalDiminishedFifth FifthDiminished { get; private set; }

        public IntervalDiminishedSeventh SeventhDiminished { get; private set; }

        public override ChordAlias Alias { get; }
            = ChordAlias.MinorDiminishedSeventhDiminished;

        public override string Description { get; }
            = "Un accord dim7 est un accord 7 dont toutes les notes ont été diminuées " +
              "d'un demi-ton (1 case) à l'exception de la fondamentale.";

        public override List<Interval> Intervals
            => new List<Interval> { Fondamental, ThirdMinor, FifthDiminished, SeventhDiminished };

        public override string Name
            => $"{Fondamental}dim7";

        public ChordMinorDiminishedSeventhDiminished SetKey(Pitch key)
        {
            Key = key;
            return this;
        }

        public override string ToString()
            => Name;

        public override Chord Clone()
            => MemberwiseClone() as Chord;
    }
}