using System.Collections.Generic;

namespace MidiMinuit.Music.Core
{
    public class ChordMinorSeventhMajor
        : Chord
    {
        private Pitch _key;

        public ChordMinorSeventhMajor()
            : this(null)
        {
        }

        public ChordMinorSeventhMajor(Pitch key)
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
                MajorSeventh = new IntervalMajorSeventh(_key);
            }
        }

        public override ChordAlias Alias { get; }
            = ChordAlias.MinorSeventhMajor;

        public override string Name { get; }
            = "Minor Seventh Major";

        public override string Description { get; }
            = "Description not added yet.";

        public override List<Interval> Intervals
            => new List<Interval> { Fondamental, MinorThird, PerfectFifth, MajorSeventh };

        public override string Abbreviation
            => Fondamental?.EndingPitch != null
                ? $"{Fondamental}min maj7"
                : null;

        public ChordMinorSeventhMajor SetKey(Pitch key)
        {
            Key = key;
            return this;
        }

        public override string ToString()
            => Abbreviation;
    }
}