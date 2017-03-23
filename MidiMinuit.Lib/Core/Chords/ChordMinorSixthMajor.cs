namespace MidiMinuit.Lib.Core.Chords
{
    using System;
    using System.Collections.Generic;
    using Intervals;
    using Notes;

    public class ChordMinorSixthMajor : Chord
    {
        public ChordMinorSixthMajor(Note fondamental)
        {
            if (fondamental == null)
            {
                throw new ArgumentNullException(nameof(fondamental));
            }

            var i = fondamental.Interval;
            Fondamental = i.Fondamental;
            ThirdMinor = i.ThirdMinor;
            FifthPerfect = i.FifthPerfect;
            SixthMajor = i.SixthMajor;
        }

        public IntervalPerfectUnison Fondamental { get; }

        public IntervalMinorThird ThirdMinor { get; }

        public IntervalPerfectFifth FifthPerfect { get; }

        public IntervalMajorSixth SixthMajor { get; }

        public override ChordAlias Alias { get; }
            = ChordAlias.MinorSixthMajor;

        public override string Description { get; }
            = "Description not added yet.";

        public override List<IntervalQuality> Notes
            => new List<IntervalQuality> { Fondamental, ThirdMinor, FifthPerfect, SixthMajor };

        public override string Name
            => $"{Fondamental}min6";

        public override string Details
            => $"Fond: {Fondamental}, 3rd min: {ThirdMinor}, 5ᵗʰ: {FifthPerfect}, 6ᵗʰ maj: {SixthMajor}";

        public override string ToString()
            => Name;

        public override Chord Clone()
            => MemberwiseClone() as Chord;
    }
}