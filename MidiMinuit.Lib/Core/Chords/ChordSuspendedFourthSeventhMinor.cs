namespace MidiMinuit.Lib.Core.Chords
{
    using System;
    using System.Collections.Generic;
    using Intervals;
    using Notes;

    public class ChordSuspendedFourthSeventhMinor : Chord
    {
        public ChordSuspendedFourthSeventhMinor(Note fondamental)
        {
            if (fondamental == null)
            {
                throw new ArgumentNullException(nameof(fondamental));
            }

            var i = fondamental.Interval;
            Fondamental = i.Fondamental;
            FourthPerfect = i.FourthPerfect;
            FifthPerfect = i.FifthPerfect;
            SeventhMinor = i.SeventhMinor;
        }

        public IntervalPerfectUnison Fondamental { get; }

        public IntervalPerfectFourth FourthPerfect { get; }

        public IntervalPerfectFifth FifthPerfect { get; }

        public IntervalMinorSeventh SeventhMinor { get; }

        public override ChordQuality Quality { get; }
            = ChordQuality.SuspendedFourthSeventhMinor;

        public override string Description { get; }
            = "Description not added yet.";

        public override List<IntervalQuality> Notes
            => new List<IntervalQuality> { Fondamental, FourthPerfect, FifthPerfect, SeventhMinor };

        public override string Name
            => $"{Fondamental}7sus4";

        public override string Details
            => $"Fond: {Fondamental}, 4ᵗʰ: {FourthPerfect}, 5ᵗʰ: {FifthPerfect}, 7ᵗʰ min: {SeventhMinor}";

        public override string ToString()
            => Name;

        public override Chord Clone()
            => MemberwiseClone() as Chord;
    }
}