namespace MidiMinuit.Lib.Core.Chords
{
    using System;
    using System.Collections.Generic;
    using Intervals;
    using Notes;

    public class ChordMinorSeventhMajor : Chord
    {
        public ChordMinorSeventhMajor(Note fondamental)
        {
            if (fondamental == null)
            {
                throw new ArgumentNullException(nameof(fondamental));
            }

            var i = fondamental.Interval;
            Fondamental = i.Fondamental;
            ThirdMinor = i.ThirdMinor;
            FifthPerfect = i.FifthPerfect;
            SeventhMajor = i.SeventhMajor;
        }

        public IntervalPerfectUnison Fondamental { get; }

        public IntervalMinorThird ThirdMinor { get; }

        public IntervalPerfectFifth FifthPerfect { get; }

        public IntervalMajorSeventh SeventhMajor { get; }

        public override ChordAlias Alias { get; }
            = ChordAlias.MinorSeventhMajor;

        public override string Description { get; }
            = "Description not added yet.";

        public override List<IntervalQuality> Notes
            => new List<IntervalQuality> { Fondamental, ThirdMinor, FifthPerfect, SeventhMajor };

        public override string Name
            => $"{Fondamental}min maj7";

        public override string Details
            => $"Fond: {Fondamental}, 3rd min: {ThirdMinor}, 5ᵗʰ: {FifthPerfect}, 7ᵗʰ maj: {SeventhMajor}";

        public override string ToString()
            => Name;

        public override Chord Clone()
            => MemberwiseClone() as Chord;
    }
}