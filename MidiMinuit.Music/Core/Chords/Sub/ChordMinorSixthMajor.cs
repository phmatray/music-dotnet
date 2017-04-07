using System.Collections.Generic;

namespace MidiMinuit.Music.Core
{
    public class ChordMinorSixthMajor
        : Chord
    {
        private Pitch _key;

        public ChordMinorSixthMajor()
            : this(null)
        {
        }

        public ChordMinorSixthMajor(Pitch key)
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
                MajorSixth = new IntervalMajorSixth(_key);
            }
        }

        public override ChordAlias Alias { get; }
            = ChordAlias.MinorSixthMajor;

        public override string Name { get; }
            = "Minor Sixth Major";

        public override string Description { get; }
            = "Description not added yet.";

        public override List<Interval> Intervals
            => new List<Interval> { Fondamental, MinorThird, PerfectFifth, MajorSixth };

        public override string Abbreviation
            => Fondamental?.UpperPitch != null
                ? $"{Fondamental}min6"
                : null;

        public ChordMinorSixthMajor SetKey(Pitch key)
        {
            Key = key;
            return this;
        }

        public override string ToString()
            => Abbreviation;
    }
}