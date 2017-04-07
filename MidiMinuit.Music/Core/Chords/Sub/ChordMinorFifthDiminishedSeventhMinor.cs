using System.Collections.Generic;

namespace MidiMinuit.Music.Core
{
    public class ChordMinorFifthDiminishedSeventhMinor
        : Chord
    {
        private Pitch _key;

        public ChordMinorFifthDiminishedSeventhMinor()
            : this(null)
        {
        }

        public ChordMinorFifthDiminishedSeventhMinor(Pitch key)
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
                MinorThird = new IntervalMinorThird(_key);
                DiminishedFifth = new IntervalDiminishedFifth(_key);
                MinorSeventh = new IntervalMinorSeventh(_key);
            }
        }

        public override ChordAlias Alias { get; }
            = ChordAlias.MinorFifthDiminishedSeventhMinor;

        public override string Description { get; }
            = "Description not added yet.";

        public override List<Interval> Intervals
            => new List<Interval> { Fondamental, MinorThird, DiminishedFifth, MinorSeventh };

        public override string Abbreviation
            => Fondamental == null ? null : $"{Fondamental}min7b5";

        public ChordMinorFifthDiminishedSeventhMinor SetKey(Pitch key)
        {
            Key = key;
            return this;
        }

        public override string ToString()
            => Abbreviation;
    }
}