using System.Collections.Generic;

namespace MidiMinuit.Music.Core
{
    public class ChordMinorFifthDiminishedSeventhMinor
        : Chord
    {
        private Pitch _key;

        public ChordMinorFifthDiminishedSeventhMinor()
        {
        }

        public ChordMinorFifthDiminishedSeventhMinor(Pitch key)
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
                SeventhMinor = new IntervalMinorSeventh(_key);
            }
        }

        public IntervalMinorThird ThirdMinor { get; private set; }

        public IntervalDiminishedFifth FifthDiminished { get; private set; }

        public IntervalMinorSeventh SeventhMinor { get; private set; }

        public override ChordAlias Alias { get; }
            = ChordAlias.MinorFifthDiminishedSeventhMinor;

        public override string Description { get; }
            = "Description not added yet.";

        public override List<Interval> Intervals
            => new List<Interval> { Fondamental, ThirdMinor, FifthDiminished, SeventhMinor };

        public override string Name
            => $"{Fondamental}min7b5";

        public ChordMinorFifthDiminishedSeventhMinor SetKey(Pitch key)
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