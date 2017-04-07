using System.Collections.Generic;

namespace MidiMinuit.Music.Core
{
    public class ChordSuspendedFourthSeventhMinor
        : Chord
    {
        private Pitch _key;

        public ChordSuspendedFourthSeventhMinor()
            : this(null)
        {
        }

        public ChordSuspendedFourthSeventhMinor(Pitch key)
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
                SeventhMinor = new IntervalMinorSeventh(_key);
            }
        }

        public IntervalPerfectFourth FourthPerfect { get; private set; }

        public IntervalPerfectFifth FifthPerfect { get; private set; }

        public IntervalMinorSeventh SeventhMinor { get; private set; }

        public override ChordAlias Alias { get; }
            = ChordAlias.SuspendedFourthSeventhMinor;

        public override string Description { get; }
            = "Description not added yet.";

        public override List<Interval> Intervals
            => new List<Interval> { Fondamental, FourthPerfect, FifthPerfect, SeventhMinor };

        public override string Abbreviation
            => Fondamental?.UpperPitch != null
                ? $"{Fondamental}7sus4"
                : null;

        public ChordSuspendedFourthSeventhMinor SetKey(Pitch key)
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