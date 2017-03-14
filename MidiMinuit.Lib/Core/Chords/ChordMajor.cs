namespace MidiMinuit.Lib.Core.Chords
{
    using System;
    using System.Collections.Generic;
    using MidiMinuit.Lib.Core.Intervals;
    using MidiMinuit.Lib.Core.Notes;

    public class ChordMajor : ChordBase
    {
        public IntervalPerfectUnison Fondamental { get; }

        public IntervalMajorThird ThirdMajor { get; }

        public IntervalPerfectFifth FifthPerfect { get; }

        public ChordMajor(Note fondamental)
            : base(ChordQualityEnum.Major)
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

        public override List<NoteQuality> Notes
            => new List<NoteQuality> { Fondamental, ThirdMajor, FifthPerfect };

        public override string Name
            => $"{Fondamental}maj";

        public override string Details
            => $"Fond. {Fondamental}, 3ʳᵈ {ThirdMajor}, 5ᵗʰ {FifthPerfect}";

        public override string Description
            => "Description not added yet.";

        public override string ToString()
        {
            return Name;
        }
    }
}