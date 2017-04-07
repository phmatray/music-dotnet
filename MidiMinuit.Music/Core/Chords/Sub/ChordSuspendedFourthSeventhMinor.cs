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

        public override Pitch Key
        {
            get
            {
                return _key;
            }

            set
            {
                _key = value;
                Fondamental = new IntervalPerfectUnison(_key);
                PerfectFourth = new IntervalPerfectFourth(_key);
                PerfectFifth = new IntervalPerfectFifth(_key);
                MinorSeventh = new IntervalMinorSeventh(_key);
            }
        }

        public override ChordAlias Alias { get; }
            = ChordAlias.SuspendedFourthSeventhMinor;

        public override string Description { get; }
            = "Description not added yet.";

        public override List<Interval> Intervals
            => new List<Interval> { Fondamental, PerfectFourth, PerfectFifth, MinorSeventh };

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