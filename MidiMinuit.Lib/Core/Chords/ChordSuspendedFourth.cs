namespace MidiMinuit.Lib.Core.Chords
{
    using System;
    using System.Collections.Generic;
    using Intervals;
    using Notes;

    public class ChordSuspendedFourth : Chord
    {
        public ChordSuspendedFourth(Note fondamental)
        {
            if (fondamental == null)
            {
                throw new ArgumentNullException(nameof(fondamental));
            }

            var i = fondamental.Interval;
            Fondamental = i.Fondamental;
            FourthPerfect = i.FourthPerfect;
            FifthPerfect = i.FifthPerfect;
        }

        public IntervalPerfectUnison Fondamental { get; }

        public IntervalPerfectFourth FourthPerfect { get; }

        public IntervalPerfectFifth FifthPerfect { get; }

        public override ChordQuality Quality { get; }
            = ChordQuality.SuspendedFourth;

        public override string Description { get; }
            = "Description not added yet.";

        public override List<IntervalQuality> Notes
            => new List<IntervalQuality> { Fondamental, FourthPerfect, FifthPerfect };

        public override string Name
            => $"{Fondamental}sus4";

        public override string Details
            => $"Fond: {Fondamental}, 4ᵗʰ: {FourthPerfect}, 5ᵗʰ: {FifthPerfect}";

        public override string ToString()
            => Name;

        public override Chord Clone()
            => MemberwiseClone() as Chord;
    }
}