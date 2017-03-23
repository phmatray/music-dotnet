namespace MidiMinuit.Lib.Core.Chords
{
    using System;
    using System.Collections.Generic;
    using Intervals;
    using Notes;

    public class ChordMajorAugmentedSeventhMinor
        : Chord
    {
        public ChordMajorAugmentedSeventhMinor(Note fondamental)
        {
            if (fondamental == null)
            {
                throw new ArgumentNullException(nameof(fondamental));
            }
            
            Fondamental = new IntervalPerfectUnison(fondamental);
            ThirdMajor = new IntervalMajorThird(fondamental);
            FifthAugmented = new IntervalAugmentedFifth(fondamental);
            SeventhMinor = new IntervalMinorSeventh(fondamental);
        }

        public IntervalPerfectUnison Fondamental { get; }

        public IntervalMajorThird ThirdMajor { get; }

        public IntervalAugmentedFifth FifthAugmented { get; }

        public IntervalMinorSeventh SeventhMinor { get; }

        public override ChordAlias Alias { get; }
            = ChordAlias.MajorAugmentedSeventhMinor;

        public override string Description { get; }
            = "Description not added yet.";

        public override List<Interval> Notes
            => new List<Interval> { Fondamental, ThirdMajor, FifthAugmented, SeventhMinor };

        public override string Name
            => $"{Fondamental}aug7";

        public override string Details
            => $"Fond: {Fondamental}, 3rd maj: {ThirdMajor}, 5ᵗʰ ♯: {FifthAugmented}, 7th min: {SeventhMinor}";

        public override string ToString()
            => Name;

        public override Chord Clone()
            => MemberwiseClone() as Chord;
    }
}