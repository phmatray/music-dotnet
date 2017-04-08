using System.Collections.Generic;

namespace MidiMinuit.Music.Core
{
    public class ChordMajorNinthMajor
        : Chord
    {
        private Pitch _key;

        public ChordMajorNinthMajor()
            : this(null)
        {
        }

        public ChordMajorNinthMajor(Pitch key)
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
                MajorThird = new IntervalMajorThird(_key);
                PerfectFifth = new IntervalPerfectFifth(_key);
                MajorNinth = new IntervalMajorNinth(_key);
            }
        }

        public override ChordAlias Alias { get; }
            = ChordAlias.MajorNinthMajor;

        public override string Name { get; }
            = "Major Ninth Major";

        public override string Description { get; }
            = "Description not added yet.";

        public override List<Interval> Intervals
            => new List<Interval> { Fondamental, MajorThird, PerfectFifth, MajorNinth };

        public override string Abbreviation
            => Fondamental?.EndingPitch != null
                ? $"{Fondamental}add9"
                : null;

        public ChordMajorNinthMajor SetKey(Pitch key)
        {
            Key = key;
            return this;
        }

        public override string ToString()
            => Abbreviation;
    }
}