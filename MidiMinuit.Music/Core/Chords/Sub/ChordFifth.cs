using System.Collections.Generic;

namespace MidiMinuit.Music.Core
{
    public class ChordFifth
        : Chord
    {
        private Pitch _key;

        public ChordFifth()
            : this(null)
        {
        }

        public ChordFifth(Pitch key)
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
                PerfectFifth = new IntervalPerfectFifth(_key);
            }
        }

        public override ChordAlias Alias { get; }
            = ChordAlias.Fifth;

        public override string Name { get; }
            = "Fifth";

        public override string Description { get; }
            = "Description not added yet.";

        public override List<Interval> Intervals
            => new List<Interval> { Fondamental, PerfectFifth };

        public override string Abbreviation
            => Fondamental?.EndingPitch != null
                ? $"{Fondamental}5"
                : null;

        public ChordFifth SetKey(Pitch key)
        {
            Key = key;
            return this;
        }

        public override string ToString()
            => Abbreviation;
    }
}