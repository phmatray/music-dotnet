using System.Collections.Generic;

namespace MidiMinuit.Music.Core
{
    public class ChordSuspendedFourth
        : Chord
    {
        private Pitch _key;

        public ChordSuspendedFourth()
            : this(null)
        {
        }

        public ChordSuspendedFourth(Pitch key)
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
                PerfectFourth = new IntervalPerfectFourth(_key);
                PerfectFifth = new IntervalPerfectFifth(_key);
            }
        }

        public override ChordAlias Alias { get; }
            = ChordAlias.SuspendedFourth;

        public override string Description { get; }
            = "Description not added yet.";

        public override List<Interval> Intervals
            => new List<Interval> { Fondamental, PerfectFourth, PerfectFifth };

        public override string Abbreviation
            => Fondamental?.UpperPitch != null
                ? $"{Fondamental}sus4"
                : null;

        public ChordSuspendedFourth SetKey(Pitch key)
        {
            Key = key;
            return this;
        }

        public override string ToString()
            => Abbreviation;
    }
}