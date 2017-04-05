using System.Collections.Generic;
using MidiMinuit.Music.Core.Intervals;
using MidiMinuit.Music.Core.Pitches;

namespace MidiMinuit.Music.Core.Chords
{
    public class ChordMinorDiminished
        : Chord
    {
        private Pitch _key;

        public ChordMinorDiminished()
        {
        }

        public ChordMinorDiminished(Pitch key)
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
                ThirdMinor = new IntervalMinorThird(_key);
                FifthDiminished = new IntervalDiminishedFifth(_key);
            }
        }

        public IntervalMinorThird ThirdMinor { get; private set; }

        public IntervalDiminishedFifth FifthDiminished { get; private set; }

        public override ChordAlias Alias { get; }
            = ChordAlias.MinorDiminished;

        public override string Description { get; }
            = "Description not added yet.";

        public override List<Interval> Intervals
            => new List<Interval> { Fondamental, ThirdMinor, FifthDiminished };

        public override string Name
            => $"{Fondamental}dim";

        public ChordMinorDiminished SetKey(Pitch key)
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