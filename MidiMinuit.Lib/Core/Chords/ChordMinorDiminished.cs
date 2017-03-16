namespace MidiMinuit.Lib.Core.Chords
{
    using System;
    using System.Collections.Generic;
    using Intervals;
    using Notes;

    public class ChordMinorDiminished : Chord
    {
        public IntervalPerfectUnison Fondamental { get; }

        public IntervalMinorThird ThirdMinor { get; }

        public IntervalDiminishedFifth FifthDiminished { get; }

        public ChordMinorDiminished(Note fondamental)
        {
            if (fondamental == null)
            {
                throw new ArgumentNullException(nameof(fondamental));
            }

            var i = fondamental.Interval;
            Fondamental = i.Fondamental;
            ThirdMinor = i.ThirdMinor;
            FifthDiminished = i.FifthDiminished;
        }

        public override ChordQualityEnum Quality
            => ChordQualityEnum.MinorDiminished;

        public override List<IntervalQuality> Notes
            => new List<IntervalQuality> { Fondamental, ThirdMinor, FifthDiminished };

        public override string Name
            => $"{Fondamental}dim";

        public override string Details
            => $"Fond: {Fondamental}, 3rd min: {ThirdMinor}, 5ᵗʰ ♭: {FifthDiminished}";

        public override string Description
            => "Description not added yet.";

        public override string ToString()
        {
            return Name;
        }

        public override Chord Clone()
        {
            return MemberwiseClone() as Chord;
        }
    }
}