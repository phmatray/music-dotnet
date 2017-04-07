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

        public Pitch Key
        {
            get
            {
                return _key;
            }

            set
            {
                _key = value;
                Fondamental = new IntervalPerfectUnison(_key);
                ThirdMajor = new IntervalMajorThird(_key);
                FifthAugmented = new IntervalAugmentedFifth(_key);
            }
        }

        public IntervalMajorThird ThirdMajor { get; private set; }

        public IntervalAugmentedFifth FifthAugmented { get; private set; }

        public override ChordAlias Alias { get; }
            = ChordAlias.MajorAugmented;

        public override string Description { get; }
            = "Description not added yet.";

        public override List<Interval> Intervals
            => new List<Interval> { Fondamental, ThirdMajor, FifthAugmented };

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

        public override Chord Clone()
            => MemberwiseClone() as Chord;
    }
}