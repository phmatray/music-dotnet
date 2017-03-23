namespace MidiMinuit.Lib.Core.Chords
{
    using System;
    using System.Collections.Generic;
    using Intervals;
    using Notes;

    public class ChordMajorAugmented : Chord
    {
        public ChordMajorAugmented(Note fondamental)
        {
            if (fondamental == null)
            {
                throw new ArgumentNullException(nameof(fondamental));
            }

            var i = fondamental.Interval;
            Fondamental = i.Fondamental;
            ThirdMajor = i.ThirdMajor;
            FifthAugmented = i.FifthAugmented;
        }

        public IntervalPerfectUnison Fondamental { get; }

        public IntervalMajorThird ThirdMajor { get; }

        public IntervalAugmentedFifth FifthAugmented { get; }

        public override ChordAlias Alias { get; }
            = ChordAlias.MajorAugmented;

        public override string Description { get; }
            = "Description not added yet.";

        public override List<IntervalQuality> Notes
            => new List<IntervalQuality> { Fondamental, ThirdMajor, FifthAugmented };

        public override string Name
            => $"{Fondamental}aug";

        public override string Details
            => $"Fond: {Fondamental}, 3rd maj: {ThirdMajor}, 5ᵗʰ ♯: {FifthAugmented}";

        public override string ToString()
            => Name;

        public override Chord Clone()
            => MemberwiseClone() as Chord;
    }
}