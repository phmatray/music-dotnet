using System.Collections.Generic;
using MidiMinuit.Music.Core.Intervals;
using MidiMinuit.Music.Core.Pitches;

namespace MidiMinuit.Music.Core.Chords
{
    public class ChordMajorSeventhMajor
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
                SeventhMajor = new IntervalMajorSeventh(_key);
            }
        }

        public IntervalMajorThird ThirdMajor { get; private set; }

        public IntervalPerfectFifth FifthPerfect { get; private set; }

        public IntervalMajorSeventh SeventhMajor { get; private set; }

        public override ChordAlias Alias { get; }
            = ChordAlias.MajorSeventhMajor;

        public override string Description { get; }
            = "Description not added yet.";

        public override List<Interval> Intervals
            => new List<Interval> { Fondamental, ThirdMajor, FifthPerfect, SeventhMajor };

        public override string Name
            => $"{Fondamental}M7";

        public override string ToString()
            => Name;

        public override Chord Clone()
            => MemberwiseClone() as Chord;
    }
}