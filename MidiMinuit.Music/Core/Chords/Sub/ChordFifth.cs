using System.Collections.Generic;
using MidiMinuit.Music.Core.Intervals;
using MidiMinuit.Music.Core.Pitches;

namespace MidiMinuit.Music.Core.Chords
{
    public class ChordFifth
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
                FifthPerfect = new IntervalPerfectFifth(_key);
            }
        }

        public IntervalPerfectFifth FifthPerfect { get; private set; }

        public override ChordAlias Alias { get; }
            = ChordAlias.Fifth;

        public override string Description { get; }
            = "Description not added yet.";

        public override List<Interval> Intervals
            => new List<Interval> { Fondamental, FifthPerfect };

        public override string Name
            => $"{Fondamental}5";

        public override string ToString()
            => Name;

        public override Chord Clone()
            => MemberwiseClone() as Chord;
    }
}