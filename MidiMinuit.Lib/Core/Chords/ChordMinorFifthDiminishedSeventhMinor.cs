namespace MidiMinuit.Lib.Core.Chords
{
    using System;
    using System.Collections.Generic;
    using Intervals;
    using Notes;

    public class ChordMinorFifthDiminishedSeventhMinor : Chord
    {
        public ChordMinorFifthDiminishedSeventhMinor(Note fondamental)
        {
            if (fondamental == null)
            {
                throw new ArgumentNullException(nameof(fondamental));
            }

            var i = fondamental.Interval;
            Fondamental = i.Fondamental;
            ThirdMinor = i.ThirdMinor;
            FifthDiminished = i.FifthDiminished;
            SeventhMinor = i.SeventhMinor;
        }

        public IntervalPerfectUnison Fondamental { get; }

        public IntervalMinorThird ThirdMinor { get; }

        public IntervalDiminishedFifth FifthDiminished { get; }

        public IntervalMinorSeventh SeventhMinor { get; }

        public override ChordAlias Alias { get; }
            = ChordAlias.MinorFifthDiminishedSeventhMinor;

        public override string Description { get; }
            = "Description not added yet.";

        public override List<IntervalQuality> Notes
            => new List<IntervalQuality> { Fondamental, ThirdMinor, FifthDiminished, SeventhMinor };

        public override string Name
            => $"{Fondamental}min7b5";

        public override string Details
            => $"Fond: {Fondamental}, 3rd min: {ThirdMinor}, 5ᵗʰ♭: {FifthDiminished}, 7ᵗʰ min: {SeventhMinor}";

        public override string ToString()
            => Name;

        public override Chord Clone()
            => MemberwiseClone() as Chord;
    }
}