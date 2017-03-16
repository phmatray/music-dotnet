namespace MidiMinuit.Lib.Core.Chords
{
    using System;
    using System.Collections.Generic;
    using Intervals;
    using Notes;

    public class ChordMajorAugmented : ChordBase
    {
        public IntervalPerfectUnison Fondamental { get; }

        public IntervalMajorThird ThirdMajor { get; }

        public IntervalAugmentedFifth FifthAugmented { get; }

        public ChordMajorAugmented(Note fondamental)
            : base(ChordQuality.MajorAugmented)
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

        public override List<IntervalQuality> Notes
            => new List<IntervalQuality> { Fondamental, ThirdMajor, FifthAugmented };

        public override string Name
            => $"{Fondamental}aug";

        public override string Details
            => $"Fond: {Fondamental}, 3rd maj: {ThirdMajor}, 5ᵗʰ ♯: {FifthAugmented}";

        public override string Description
            => "Description not added yet.";

        public override string ToString()
        {
            return Name;
        }

        public override ChordBase Clone()
        {
            return MemberwiseClone() as ChordBase;
        }
    }
}