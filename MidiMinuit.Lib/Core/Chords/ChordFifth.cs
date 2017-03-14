namespace MidiMinuit.Lib.Core.Chords
{
    using System;
    using System.Collections.Generic;
    using MidiMinuit.Lib.Core.Intervals;
    using MidiMinuit.Lib.Core.Notes;

    public class ChordFifth : ChordBase
    {
        public NoteFondamental Fondamental { get; }

        public IntervalPerfectFifth FifthPerfect { get; }

        public ChordFifth(Note fondamental)
            : base(ChordQualityEnum.Fifth)
        {
            if (fondamental == null)
            {
                throw new ArgumentNullException(nameof(fondamental));
            }

            var i = fondamental.Interval;
            Fondamental = i.Fondamental;
            FifthPerfect = i.FifthPerfect;
        }

        public override List<NoteQuality> Notes
            => new List<NoteQuality> { Fondamental, FifthPerfect };

        public override string Name
            => $"{Fondamental}5";

        public override string Details
            => $"Fond. {Fondamental}, 5ᵗʰ {FifthPerfect}";

        public override string Description
            => "Description not added yet.";

        public override string ToString()
        {
            return Name;
        }
    }
}