using System.Collections.Generic;

namespace MidiMinuit.Music.Core
{
    public class ChordMajorAugmentedSeventhMinor
        : Chord
    {
        private Pitch _key;

        public ChordMajorAugmentedSeventhMinor()
            : this(null)
        {
        }

        public ChordMajorAugmentedSeventhMinor(Pitch key)
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
                MinorSeventh = new IntervalMinorSeventh(_key);
            }
        }

        public override ChordAlias Alias { get; }
            = ChordAlias.MajorAugmentedSeventhMinor;

        public override string Name { get; }
            = "Major Augmented Seventh Minor";

        public override string Description { get; }
            = "Description not added yet.";

        public override List<Interval> Intervals
            => new List<Interval> { Fondamental, MajorThird, AugmentedFifth, MinorSeventh };

        public override string Abbreviation
            => Fondamental?.UpperPitch != null
                ? $"{Fondamental}aug7"
                : null;

        public ChordMajorAugmentedSeventhMinor SetKey(Pitch key)
        {
            Key = key;
            return this;
        }

        public override string ToString()
            => Abbreviation;
    }
}