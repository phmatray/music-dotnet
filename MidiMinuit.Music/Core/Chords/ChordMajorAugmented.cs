using System;
using System.Collections.Generic;
using MidiMinuit.Music.Core.Intervals;
using MidiMinuit.Music.Core.Notes;

namespace MidiMinuit.Music.Core.Chords
{
    public class ChordMajorAugmented
        : Chord
    {
        public ChordMajorAugmented(Pitch fondamental)
        {
            if (fondamental == null)
            {
                throw new ArgumentNullException(nameof(fondamental));
            }

            Fondamental = new IntervalPerfectUnison(fondamental);
            ThirdMajor = new IntervalMajorThird(fondamental);
            FifthAugmented = new IntervalAugmentedFifth(fondamental);
        }

        public IntervalPerfectUnison Fondamental { get; }

        public IntervalMajorThird ThirdMajor { get; }

        public IntervalAugmentedFifth FifthAugmented { get; }

        public override ChordAlias Alias { get; }
            = ChordAlias.MajorAugmented;

        public override string Description { get; }
            = "Description not added yet.";

        public override List<Interval> Intervals
            => new List<Interval> { Fondamental, ThirdMajor, FifthAugmented };

        public override string Name
            => $"{Fondamental}aug";

        public override string ToString()
            => Name;

        public override Chord Clone()
            => MemberwiseClone() as Chord;
    }
}