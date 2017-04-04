using System.Collections.Generic;
using MidiMinuit.Music.Core.Intervals;
using MidiMinuit.Music.Core.Pitches;

namespace MidiMinuit.Music.Core.Chords
{
    public class ChordMajorAugmentedSeventhMinor
        : Chord
    {
        private Pitch _key;

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
                SeventhMinor = new IntervalMinorSeventh(_key);
            }
        }

        public IntervalMajorThird ThirdMajor { get; private set; }

        public IntervalAugmentedFifth FifthAugmented { get; private set; }

        public IntervalMinorSeventh SeventhMinor { get; private set; }

        public override ChordAlias Alias { get; }
            = ChordAlias.MajorAugmentedSeventhMinor;

        public override string Description { get; }
            = "Description not added yet.";

        public override List<Interval> Intervals
            => new List<Interval> { Fondamental, ThirdMajor, FifthAugmented, SeventhMinor };

        public override string Name
            => $"{Fondamental}aug7";

        public override string ToString()
            => Name;

        public override Chord Clone()
            => MemberwiseClone() as Chord;
    }
}