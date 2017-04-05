using System.Collections.Generic;

namespace MidiMinuit.Music.Core
{
    public class ChordMinorSeventhMajor
        : Chord
    {
        private Pitch _key;

        public ChordMinorSeventhMajor()
        {
        }

        public ChordMinorSeventhMajor(Pitch key)
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
                FifthPerfect = new IntervalPerfectFifth(_key);
                SeventhMajor = new IntervalMajorSeventh(_key);
            }
        }

        public IntervalMinorThird ThirdMinor { get; private set; }

        public IntervalPerfectFifth FifthPerfect { get; private set; }

        public IntervalMajorSeventh SeventhMajor { get; private set; }

        public override ChordAlias Alias { get; }
            = ChordAlias.MinorSeventhMajor;

        public override string Description { get; }
            = "Description not added yet.";

        public override List<Interval> Intervals
            => new List<Interval> { Fondamental, ThirdMinor, FifthPerfect, SeventhMajor };

        public override string Name
            => $"{Fondamental}min maj7";

        public ChordMinorSeventhMajor SetKey(Pitch key)
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