namespace MidiMinuit.Lib.Core.Chords
{
    using System;
    using System.Collections.Generic;
    using Intervals;
    using Notes;

    public class ChordMajorSeventhMinor : Chord
    {
        public ChordMajorSeventhMinor(Note fondamental)
        {
            if (fondamental == null)
            {
                throw new ArgumentNullException(nameof(fondamental));
            }

            var i = fondamental.Interval;
            Fondamental = i.Fondamental;
            ThirdMajor = i.ThirdMajor;
            FifthPerfect = i.FifthPerfect;
            SeventhMinor = i.SeventhMinor;
        }

        public IntervalPerfectUnison Fondamental { get; }

        public IntervalMajorThird ThirdMajor { get; }

        public IntervalPerfectFifth FifthPerfect { get; }

        public IntervalMinorSeventh SeventhMinor { get; }

        public override ChordAlias Alias { get; }
            = ChordAlias.MajorSeventhMinor;

        public override string Description { get; }
            = "Description not added yet.";

        public override List<IntervalQuality> Notes
            => new List<IntervalQuality> { Fondamental, ThirdMajor, FifthPerfect, SeventhMinor };

        public override string Name
            => $"{Fondamental}7";

        public override string Details
            => $"Fond: {Fondamental}, 3rd maj: {ThirdMajor}, 5ᵗʰ: {FifthPerfect}, 7ᵗʰ min: {SeventhMinor}";

        public override string ToString()
            => Name;

        public override Chord Clone()
            => MemberwiseClone() as Chord;
    }
}