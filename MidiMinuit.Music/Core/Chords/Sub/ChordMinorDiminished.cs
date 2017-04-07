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
            }
        }

        public IntervalMinorThird ThirdMinor { get; private set; }

        public IntervalDiminishedFifth FifthDiminished { get; private set; }

        public override ChordAlias Alias { get; }
            = ChordAlias.MinorDiminished;

        public override string Description { get; }
            = "Description not added yet.";

        public override List<Interval> Intervals
            => new List<Interval> { Fondamental, ThirdMinor, FifthDiminished };

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

        public override Chord Clone()
            => MemberwiseClone() as Chord;
    }
}