namespace MidiMinuit.Lib.Core.Chords
{
    using System;
    using System.Collections.Generic;
    using Intervals;
    using Notes;

    public class ChordFifth : Chord
    {
        public ChordFifth(Note fondamental)
        {
            if (fondamental == null)
            {
                throw new ArgumentNullException(nameof(fondamental));
            }

            var i = fondamental.Interval;
            Fondamental = i.Fondamental;
            FifthPerfect = i.FifthPerfect;
        }

        public IntervalPerfectUnison Fondamental { get; }

        public IntervalPerfectFifth FifthPerfect { get; }

        public override ChordAlias Alias { get; }
            = ChordAlias.Fifth;

        public override string Description { get; }
            = "Description not added yet.";

        public override List<IntervalQuality> Notes
            => new List<IntervalQuality> { Fondamental, FifthPerfect };

        public override string Name
            => $"{Fondamental}5";

        public override string Details
            => $"Fond. {Fondamental}, 5ᵗʰ {FifthPerfect}";

        public override string ToString()
            => Name;

        public override Chord Clone()
            => MemberwiseClone() as Chord;
    }
}