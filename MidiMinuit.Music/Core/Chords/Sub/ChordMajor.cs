using System.Collections.Generic;

namespace MidiMinuit.Music.Core
{
    public class ChordMajor
        : Chord
    {
        private Pitch _key;

        public ChordMajor()
            : this(null)
        {
        }

        public ChordMajor(Pitch key)
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
            }
        }

        public override ChordAlias Alias { get; }
            = ChordAlias.Major;

        public override string Description { get; }
            = "Description not added yet.";

        public override List<Interval> Intervals
            => new List<Interval> { Fondamental, MajorThird, PerfectFifth };

        // TODO: Apply this modification to other Chord classes.
        public override string Abbreviation
            => Fondamental?.UpperPitch != null
                ? $"{Fondamental.UpperPitch.ToStep()} maj"
                : null;

        public ChordMajor SetKey(Pitch key)
        {
            Key = key;
            return this;
        }

        public override string ToString()
            => Abbreviation;
    }
}