using System.Collections.Generic;
using MidiMinuit.Music.Core.Intervals;
using MidiMinuit.Music.Core.Pitches;

namespace MidiMinuit.Music.Core.Chords
{
    public class ChordMajor
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
                FifthPerfect = new IntervalPerfectFifth(_key);
            }
        }

        public IntervalMajorThird ThirdMajor { get; private set; }

        public IntervalPerfectFifth FifthPerfect { get; private set; }

        public override ChordAlias Alias { get; }
            = ChordAlias.Major;

        public override string Description { get; }
            = "Description not added yet.";

        public override List<Interval> Intervals
            => new List<Interval> { Fondamental, ThirdMajor, FifthPerfect };

        public override string Name
            => $"{Fondamental.UpperPitch}maj";

        public override string ToString()
            => Name;

        public override Chord Clone()
            => MemberwiseClone() as Chord;
    }
}