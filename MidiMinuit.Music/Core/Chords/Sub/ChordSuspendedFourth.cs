using System.Collections.Generic;

namespace MidiMinuit.Music.Core
{
    public class ChordSuspendedFourth
        : Chord
    {
        private Pitch _key;

        public ChordSuspendedFourth()
            : this(null)
        {
        }

        public ChordSuspendedFourth(Pitch key)
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
                FourthPerfect = new IntervalPerfectFourth(_key);
                FifthPerfect = new IntervalPerfectFifth(_key);
            }
        }

        public IntervalPerfectFourth FourthPerfect { get; private set; }

        public IntervalPerfectFifth FifthPerfect { get; private set; }

        public override ChordAlias Alias { get; }
            = ChordAlias.SuspendedFourth;

        public override string Description { get; }
            = "Description not added yet.";

        public override List<Interval> Intervals
            => new List<Interval> { Fondamental, FourthPerfect, FifthPerfect };

        public override string Abbreviation
            => Fondamental?.UpperPitch != null
                ? $"{Fondamental}sus4"
                : null;

        public ChordSuspendedFourth SetKey(Pitch key)
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