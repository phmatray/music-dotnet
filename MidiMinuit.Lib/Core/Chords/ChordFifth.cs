namespace MidiMinuit.Lib.Core.Chords
{
    using System;
    using System.Collections.Generic;
    using Intervals;
    using Notes;

    public class ChordFifth : Chord
    {
        public IntervalPerfectUnison Fondamental { get; }

        public IntervalPerfectFifth FifthPerfect { get; }

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

        public override ChordQualityEnum Quality
            => ChordQualityEnum.Fifth;

        public override List<IntervalQuality> Notes
            => new List<IntervalQuality> { Fondamental, FifthPerfect };

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

        public override Chord Clone()
        {
            return MemberwiseClone() as Chord;
        }
    }
}