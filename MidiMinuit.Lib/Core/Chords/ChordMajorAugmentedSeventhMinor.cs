namespace MidiMinuit.Lib.Core.Chords
{
    using System;
    using System.Collections.Generic;
    using Intervals;
    using Notes;

    public class ChordMajorAugmentedSeventhMinor : ChordBase
    {
        public IntervalPerfectUnison Fondamental { get; }

        public IntervalMajorThird ThirdMajor { get; }

        public IntervalAugmentedFifth FifthAugmented { get; }

        public IntervalMinorSeventh SeventhMinor { get; }

        public ChordMajorAugmentedSeventhMinor(Note fondamental)
            : base(ChordQualityEnum.MajorAugmentedSeventhMinor)
        {
            if (fondamental == null)
            {
                throw new ArgumentNullException(nameof(fondamental));
            }

            var i = fondamental.Interval;
            Fondamental = i.Fondamental;
            ThirdMajor = i.ThirdMajor;
            FifthAugmented = i.FifthAugmented;
            SeventhMinor = i.SeventhMinor;
        }

        public override List<IntervalQuality> Notes
            => new List<IntervalQuality> { Fondamental, ThirdMajor, FifthAugmented, SeventhMinor };

        public override string Name
            => $"{Fondamental}aug7";

        public override string Details
            => $"Fond: {Fondamental}, 3rd maj: {ThirdMajor}, 5ᵗʰ ♯: {FifthAugmented}, 7th min: {SeventhMinor}";

        public override string Description
            => "Description not added yet.";

        public override string ToString()
        {
            return Name;
        }
    }
}