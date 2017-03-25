namespace MidiMinuit.Lib.Core.Chords
{
    using System;
    using System.Collections.Generic;
    using Intervals;
    using Notes;

    public class ChordMajorSeventhMajor
        : Chord
    {
        public ChordMajorSeventhMajor(Note fondamental)
        {
            if (fondamental == null)
            {
                throw new ArgumentNullException(nameof(fondamental));
            }

            Fondamental = new IntervalPerfectUnison(fondamental);
            ThirdMajor = new IntervalMajorThird(fondamental);
            FifthPerfect = new IntervalPerfectFifth(fondamental);
            SeventhMajor = new IntervalMajorSeventh(fondamental);
        }

        public IntervalPerfectUnison Fondamental { get; }

        public IntervalMajorThird ThirdMajor { get; }

        public IntervalPerfectFifth FifthPerfect { get; }

        public IntervalMajorSeventh SeventhMajor { get; }

        public override ChordAlias Alias { get; }
            = ChordAlias.MajorSeventhMajor;

        public override string Description { get; }
            = "Description not added yet.";

        public override List<Interval> Intervals
            => new List<Interval> { Fondamental, ThirdMajor, FifthPerfect, SeventhMajor };

        public override string Name
            => $"{Fondamental}M7";

        public override string ToString()
            => Name;

        public override Chord Clone()
            => MemberwiseClone() as Chord;
    }
}