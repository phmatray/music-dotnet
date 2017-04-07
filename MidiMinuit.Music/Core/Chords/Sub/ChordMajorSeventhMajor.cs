using System.Collections.Generic;

namespace MidiMinuit.Music.Core
{
    public class ChordMajorSeventhMajor
        : Chord
    {
        private Pitch _key;

        public ChordMajorSeventhMajor()
            : this(null)
        {
        }

        public ChordMajorSeventhMajor(Pitch key)
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

        public override string Abbreviation
            => Fondamental?.UpperPitch != null
                ? $"{Fondamental}M7"
                : null;

        public ChordMajorSeventhMajor SetKey(Pitch key)
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