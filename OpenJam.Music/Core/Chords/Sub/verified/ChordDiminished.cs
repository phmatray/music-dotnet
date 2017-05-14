using System.Collections.Generic;

namespace OpenJam.Music.Core
{
    public class ChordDiminished
        : Chord
    {
        private Pitch _key;

        public ChordDiminished()
            : this(null)
        {
        }

        public ChordDiminished(Pitch key)
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
            = ChordAlias.Diminished;

        public override string Name { get; }
            = "Diminished";

        public override string Description { get; }
            = "Description not added yet.";

        public override List<Interval> Intervals
            => new List<Interval> { Fondamental, MinorThird, DiminishedFifth };

        // TODO: Apply this modification to other Chord classes.
        public override string Abbreviation
            => Fondamental?.EndingPitch != null
                ? $"{Fondamental.EndingPitch.ToStep()} dim"
                : null;

        public ChordDiminished SetKey(Pitch key)
        {
            Key = key;
            return this;
        }

        public override string ToString()
            => Abbreviation;
    }
}