using System.Collections.Generic;

namespace OpenJam.Music.Core
{
    public class ChordMajorSixthMajor
        : Chord
    {
        private Pitch _key;

        public ChordMajorSixthMajor()
            : this(null)
        {
        }

        public ChordMajorSixthMajor(Pitch key)
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
                MajorSixth = new IntervalMajorSixth(_key);
            }
        }

        public override ChordAlias Alias { get; }
            = ChordAlias.MajorSixthMajor;

        public override string Name { get; }
            = "Major Sixth Major";

        public override string Description { get; }
            = "Description not added yet.";

        public override List<Interval> Intervals
            => new List<Interval> { Fondamental, MajorThird, PerfectFifth, MajorSixth };

        public override string Abbreviation
            => Fondamental?.EndingPitch != null
                ? $"{Fondamental}6"
                : null;

        public ChordMajorSixthMajor SetKey(Pitch key)
        {
            Key = key;
            return this;
        }

        public override string ToString()
            => Abbreviation;
    }
}