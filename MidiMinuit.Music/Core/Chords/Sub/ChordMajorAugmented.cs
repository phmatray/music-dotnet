using System.Collections.Generic;

namespace MidiMinuit.Music.Core
{
    public class ChordMajorAugmented
        : Chord
    {
        private Pitch _key;

        public ChordMajorAugmented()
            : this(null)
        {
        }

        public ChordMajorAugmented(Pitch key)
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
                AugmentedFifth = new IntervalAugmentedFifth(_key);
            }
        }

        public override ChordAlias Alias { get; }
            = ChordAlias.MajorAugmented;

        public override string Description { get; }
            = "Description not added yet.";

        public override List<Interval> Intervals
            => new List<Interval> { Fondamental, MajorThird, AugmentedFifth };

        public override string Abbreviation
            => Fondamental?.UpperPitch != null
                ? $"{Fondamental}aug"
                : null;

        public ChordMajorAugmented SetKey(Pitch key)
        {
            Key = key;
            return this;
        }

        public override string ToString()
            => Abbreviation;
    }
}