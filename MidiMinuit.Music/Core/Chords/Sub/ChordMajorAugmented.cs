using System.Collections.Generic;
using MidiMinuit.Music.Core.Intervals;
using MidiMinuit.Music.Core.Pitches;

namespace MidiMinuit.Music.Core.Chords
{
    public class ChordMajorAugmented
        : Chord
    {
        private Pitch _key;

        public ChordMajorAugmented()
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

        public override string Name
            => $"{Fondamental}aug";

        public ChordMajorAugmented SetKey(Pitch key)
        {
            Key = key;
            return this;
        }

        public override string ToString()
            => Name;

        public override Chord Clone()
            => MemberwiseClone() as Chord;
    }
}