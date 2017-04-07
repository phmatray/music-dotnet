using System.Collections.Generic;

namespace MidiMinuit.Music.Core
{
    public class ChordMajorNinthMajor
        : Chord
    {
        private Pitch _key;

        public ChordMajorNinthMajor()
            : this(null)
        {
        }

        public ChordMajorNinthMajor(Pitch key)
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
                NinthMajor = new IntervalMajorNinth(_key);
            }
        }

        public IntervalMajorThird ThirdMajor { get; private set; }

        public IntervalPerfectFifth FifthPerfect { get; private set; }

        public IntervalMajorNinth NinthMajor { get; private set; }

        public override ChordAlias Alias { get; }
            = ChordAlias.MajorNinthMajor;

        public override string Description { get; }
            = "Description not added yet.";

        public override List<Interval> Intervals
            => new List<Interval> { Fondamental, ThirdMajor, FifthPerfect, NinthMajor };

        public override string Abbreviation
            => Fondamental?.UpperPitch != null
                ? $"{Fondamental}add9"
                : null;

        public ChordMajorNinthMajor SetKey(Pitch key)
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