namespace MidiMinuit.Lib.Core.Chords
{
    using System;
    using System.Collections.Generic;
    using Intervals;
    using Notes;

    public class ChordMajorSixthMajor : Chord
    {
        public ChordMajorSixthMajor(Note fondamental)
        {
            if (fondamental == null)
            {
                throw new ArgumentNullException(nameof(fondamental));
            }

            var i = fondamental.Interval;
            Fondamental = i.Fondamental;
            ThirdMajor = i.ThirdMajor;
            FifthPerfect = i.FifthPerfect;
            SixthMajor = i.SixthMajor;
        }

        public IntervalPerfectUnison Fondamental { get; }

        public IntervalMajorThird ThirdMajor { get; }

        public IntervalPerfectFifth FifthPerfect { get; }

        public IntervalMajorSixth SixthMajor { get; }

        public override ChordQualityEnum Quality { get; }
            = ChordQualityEnum.MajorSixthMajor;

        public override string Description { get; }
            = "Description not added yet.";

        public override List<IntervalQuality> Notes
            => new List<IntervalQuality> { Fondamental, ThirdMajor, FifthPerfect, SixthMajor };

        public override string Name
            => $"{Fondamental}6";

        public override string Details
            => $"Fond: {Fondamental}, 3rd maj: {ThirdMajor}, 5ᵗʰ: {FifthPerfect}, 6ᵗʰ maj: {SixthMajor}";

        public override string ToString()
            => Name;

        public override Chord Clone()
            => MemberwiseClone() as Chord;
    }
}