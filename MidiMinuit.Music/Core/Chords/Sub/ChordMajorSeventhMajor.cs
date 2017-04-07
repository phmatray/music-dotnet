using System.Collections.Generic;

namespace MidiMinuit.Music.Core
{
    public class ChordMajorSeventhMajor
        : Chord
    {
        private Pitch _key;

        public ChordMajorSeventhMajor()
            : this(null)
        {
        }

        public ChordMajorSeventhMajor(Pitch key)
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
                MajorSeventh = new IntervalMajorSeventh(_key);
            }
        }

        public override ChordAlias Alias { get; }
            = ChordAlias.MajorSeventhMajor;

        public override string Name { get; }
            = "Major Seventh Major";

        public override string Description { get; }
            = "Description not added yet.";

        public override List<Interval> Intervals
            => new List<Interval> { Fondamental, MajorThird, PerfectFifth, MajorSeventh };

        public override string Abbreviation
            => Fondamental?.UpperPitch != null
                ? $"{Fondamental}M7"
                : null;

        public ChordMajorSeventhMajor SetKey(Pitch key)
        {
            Key = key;
            return this;
        }

        public override string ToString()
            => Abbreviation;
    }
}