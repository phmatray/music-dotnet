namespace MidiMinuit.Lib.Core.Chords
{
    using System;
    using System.Collections.Generic;
    using Intervals;
    using Notes;

    public class ChordMajor : Chord
    {
        public ChordMajor(Note fondamental)
        {
            if (fondamental == null)
            {
                throw new ArgumentNullException(nameof(fondamental));
            }

            var i = fondamental.Interval;
            Fondamental = i.Fondamental;
            ThirdMajor = i.ThirdMajor;
            FifthPerfect = i.FifthPerfect;
        }

        public IntervalPerfectUnison Fondamental { get; }

        public IntervalMajorThird ThirdMajor { get; }

        public IntervalPerfectFifth FifthPerfect { get; }

        public override ChordAlias Alias { get; }
            = ChordAlias.Major;

        public override string Description { get; }
            = "Description not added yet.";

        public override List<IntervalQuality> Notes
            => new List<IntervalQuality> { Fondamental, ThirdMajor, FifthPerfect };

        public override string Name
            => $"{Fondamental}maj";

        public override string Details
            => $"Fond. {Fondamental}, 3ʳᵈ {ThirdMajor}, 5ᵗʰ {FifthPerfect}";

        public override string ToString()
            => Name;

        public override Chord Clone()
            => MemberwiseClone() as Chord;
    }
}