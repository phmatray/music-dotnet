namespace MidiMinuit.Lib.Core.Chords
{
    using System;
    using System.Collections.Generic;
    using Intervals;
    using Notes;

    public class ChordMinor : Chord
    {
        public ChordMinor(Note fondamental)
        {
            if (fondamental == null)
            {
                throw new ArgumentNullException(nameof(fondamental));
            }

            var i = fondamental.Interval;
            Fondamental = i.Fondamental;
            ThirdMinor = i.ThirdMinor;
            FifthPerfect = i.FifthPerfect;
        }

        public IntervalPerfectUnison Fondamental { get; }

        public IntervalMinorThird ThirdMinor { get; }

        public IntervalPerfectFifth FifthPerfect { get; }

        public override ChordAlias Alias { get; }
            = ChordAlias.Minor;

        public override string Description { get; }
            = "Description not added yet.";

        public override List<IntervalQuality> Notes
            => new List<IntervalQuality> { Fondamental, ThirdMinor, FifthPerfect };

        public override string Name
            => $"{Fondamental}min";

        public override string Details
            => $"Fond: {Fondamental}, 3rd min: {ThirdMinor}, 5ᵗʰ: {FifthPerfect}";

        public override string ToString()
            => Name;

        public override Chord Clone()
            => MemberwiseClone() as Chord;
    }
}