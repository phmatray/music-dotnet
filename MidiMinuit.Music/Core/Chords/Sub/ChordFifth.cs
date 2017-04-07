using System.Collections.Generic;

namespace MidiMinuit.Music.Core
{
    public class ChordFifth
        : Chord
    {
        private Pitch _key;

        public ChordFifth()
            : this(null)
        {
        }

        public ChordFifth(Pitch key)
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

        public override string Abbreviation
            => Fondamental?.UpperPitch != null
                ? $"{Fondamental}5"
                : null;

        public ChordFifth SetKey(Pitch key)
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