using System.Collections.Generic;

namespace MidiMinuit.Music.Core
{
    public class ChordMajorSixthMajor
        : Chord
    {
        private Pitch _key;

        public ChordMajorSixthMajor()
            : this(null)
        {
        }

        public ChordMajorSixthMajor(Pitch key)
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
                SixthMajor = new IntervalMajorSixth(_key);
            }
        }

        public IntervalMajorThird ThirdMajor { get; private set; }

        public IntervalPerfectFifth FifthPerfect { get; private set; }

        public IntervalMajorSixth SixthMajor { get; private set; }

        public override ChordAlias Alias { get; }
            = ChordAlias.MajorSixthMajor;

        public override string Description { get; }
            = "Description not added yet.";

        public override List<Interval> Intervals
            => new List<Interval> { Fondamental, ThirdMajor, FifthPerfect, SixthMajor };

        public override string Abbreviation
            => Fondamental?.UpperPitch != null
                ? $"{Fondamental}6"
                : null;

        public ChordMajorSixthMajor SetKey(Pitch key)
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