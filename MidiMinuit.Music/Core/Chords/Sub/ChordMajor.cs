using System.Collections.Generic;

namespace MidiMinuit.Music.Core
{
    public class ChordMajor
        : Chord
    {
        private Pitch _key;

        public ChordMajor()
            : this(null)
        {
        }

        public ChordMajor(Pitch key)
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

        // TODO: Apply this modification to other Chord classes.
        public override string Abbreviation
            => Fondamental?.UpperPitch != null
                ? $"{Fondamental.UpperPitch.ToStep()} maj"
                : null;

        public ChordMajor SetKey(Pitch key)
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