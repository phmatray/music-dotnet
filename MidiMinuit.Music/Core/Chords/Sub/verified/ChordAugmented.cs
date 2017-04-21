using System.Collections.Generic;

namespace MidiMinuit.Music.Core
{
    public class ChordAugmented
        : Chord
    {
        private Pitch _key;

        public ChordAugmented()
            : this(null)
        {
        }

        public ChordAugmented(Pitch key)
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
            = ChordAlias.Augmented;

        public override string Name { get; }
            = "Augmented";

        public override string Description { get; }
            = "Description not added yet.";

        public override List<Interval> Intervals
            => new List<Interval> { Fondamental, MajorThird, AugmentedFifth };

        // TODO: Apply this modification to other Chord classes.
        public override string Abbreviation
            => Fondamental?.EndingPitch != null
                ? $"{Fondamental.EndingPitch.ToStep()} aug"
                : null;

        public ChordAugmented SetKey(Pitch key)
        {
            Key = key;
            return this;
        }

        public override string ToString()
            => Abbreviation;
    }
}