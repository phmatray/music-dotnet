using System.Collections.Generic;

namespace MidiMinuit.Music.Core
{
    public class ChordMinorDiminished
        : Chord
    {
        private Pitch _key;

        public ChordMinorDiminished()
            : this(null)
        {
        }

        public ChordMinorDiminished(Pitch key)
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
            }
        }

        public override ChordAlias Alias { get; }
            = ChordAlias.MinorDiminished;

        public override string Description { get; }
            = "Description not added yet.";

        public override List<Interval> Intervals
            => new List<Interval> { Fondamental, MinorThird, DiminishedFifth };

        public override string Abbreviation
            => Fondamental?.UpperPitch != null
                ? $"{Fondamental}dim"
                : null;

        public ChordMinorDiminished SetKey(Pitch key)
        {
            Key = key;
            return this;
        }

        public override string ToString()
            => Abbreviation;
    }
}