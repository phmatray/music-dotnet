using System;
using System.Collections.Generic;
using MidiMinuit.Music.Core.Intervals;
using MidiMinuit.Music.Core.Notes;

namespace MidiMinuit.Music.Core.Chords
{
    public class ChordMajorNinthMajor
        : Chord
    {
        public ChordMajorNinthMajor(Pitch fondamental)
        {
            if (fondamental == null)
            {
                throw new ArgumentNullException(nameof(fondamental));
            }

            Fondamental = new IntervalPerfectUnison(fondamental);
            ThirdMajor = new IntervalMajorThird(fondamental);
            FifthPerfect = new IntervalPerfectFifth(fondamental);
            NinthMajor = new IntervalMajorNinth(fondamental);
        }

        public IntervalPerfectUnison Fondamental { get; }

        public IntervalMajorThird ThirdMajor { get; }

        public IntervalPerfectFifth FifthPerfect { get; }

        public IntervalMajorNinth NinthMajor { get; }

        public override ChordAlias Alias { get; }
            = ChordAlias.MajorNinthMajor;

        public override string Description { get; }
            = "Description not added yet.";

        public override List<Interval> Intervals
            => new List<Interval> { Fondamental, ThirdMajor, FifthPerfect, NinthMajor };

        public override string Name
            => $"{Fondamental}add9";

        public override string ToString()
            => Name;

        public override Chord Clone()
            => MemberwiseClone() as Chord;
    }
}