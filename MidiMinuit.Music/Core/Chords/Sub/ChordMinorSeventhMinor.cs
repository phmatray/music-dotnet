using System.Collections.Generic;

namespace MidiMinuit.Music.Core
{
    public class ChordMinorSeventhMinor
        : Chord
    {
        private Pitch _key;

        public ChordMinorSeventhMinor()
            : this(null)
        {
        }

        public ChordMinorSeventhMinor(Pitch key)
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
                MinorSeventh = new IntervalMinorSeventh(_key);
            }
        }

        public override ChordAlias Alias { get; }
            = ChordAlias.MinorSeventhMinor;

        public override string Name { get; }
            = "Minor Seventh Minor";

        public override string Description { get; }
            = "Description not added yet.";

        public override List<Interval> Intervals
            => new List<Interval> { Fondamental, MinorThird, PerfectFifth, MinorSeventh };

        public override string Abbreviation
            => Fondamental?.UpperPitch != null
                ? $"{Fondamental}min7"
                : null;

        public ChordMinorSeventhMinor SetKey(Pitch key)
        {
            Key = key;
            return this;
        }

        public override string ToString()
            => Abbreviation;
    }
}