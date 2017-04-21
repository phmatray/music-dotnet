using System.Collections.Generic;

namespace MidiMinuit.Music.Core
{
    public class ChordMinor
        : Chord
    {
        private Pitch _key;

        public ChordMinor()
            : this(null)
        {
        }

        public ChordMinor(Pitch key)
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
                PerfectFifth = new IntervalPerfectFifth(_key);
            }
        }

        public override ChordAlias Alias { get; }
            = ChordAlias.Minor;

        public override string Name { get; }
            = "Minor";

        public override string Description { get; }
            = "Description not added yet.";

        public override List<Interval> Intervals
            => new List<Interval> { Fondamental, MinorThird, PerfectFifth };

        public override string Abbreviation
            => Fondamental?.EndingPitch != null
                ? $"{Fondamental}min"
                : null;

        public ChordMinor SetKey(Pitch key)
        {
            Key = key;
            return this;
        }

        public override string ToString()
            => Abbreviation;
    }
}