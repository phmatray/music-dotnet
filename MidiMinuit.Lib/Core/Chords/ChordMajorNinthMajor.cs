namespace MidiMinuit.Lib.Core.Chords
{
    using System;
    using System.Collections.Generic;
    using Intervals;
    using Notes;

    public class ChordMajorNinthMajor : Chord
    {
        public ChordMajorNinthMajor(Note fondamental)
        {
            if (fondamental == null)
            {
                throw new ArgumentNullException(nameof(fondamental));
            }

            var i = fondamental.Interval;
            Fondamental = i.Fondamental;
            ThirdMajor = i.ThirdMajor;
            FifthPerfect = i.FifthPerfect;
            NinthMajor = i.NinthMajor;
        }

        public IntervalPerfectUnison Fondamental { get; }

        public IntervalMajorThird ThirdMajor { get; }

        public IntervalPerfectFifth FifthPerfect { get; }

        public IntervalMajorNinth NinthMajor { get; }

        public override ChordAlias Alias { get; }
            = ChordAlias.MajorNinthMajor;

        public override string Description { get; }
            = "Description not added yet.";

        public override List<IntervalQuality> Notes
            => new List<IntervalQuality> { Fondamental, ThirdMajor, FifthPerfect, NinthMajor };

        public override string Name
            => $"{Fondamental}add9";

        public override string Details
            => $"Fond: {Fondamental}, 3rd: {ThirdMajor}, 5ᵗʰ: {FifthPerfect}, 9ᵗʰ: {NinthMajor}";

        public override string ToString()
            => Name;

        public override Chord Clone()
            => MemberwiseClone() as Chord;
    }
}