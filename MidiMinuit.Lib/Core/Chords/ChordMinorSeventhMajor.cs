namespace MidiMinuit.Lib.Core.Chords
{
    using System;
    using System.Collections.Generic;
    using Intervals;
    using Notes;

    public class ChordMinorSeventhMajor
        : Chord
    {
        public ChordMinorSeventhMajor(Note fondamental)
        {
            if (fondamental == null)
            {
                throw new ArgumentNullException(nameof(fondamental));
            }
            
            Fondamental = new IntervalPerfectUnison(fondamental);
            ThirdMinor = new IntervalMinorThird(fondamental);
            FifthPerfect = new IntervalPerfectFifth(fondamental);
            SeventhMajor = new IntervalMajorSeventh(fondamental);
        }

        public IntervalPerfectUnison Fondamental { get; }

        public IntervalMinorThird ThirdMinor { get; }

        public IntervalPerfectFifth FifthPerfect { get; }

        public IntervalMajorSeventh SeventhMajor { get; }

        public override ChordAlias Alias { get; }
            = ChordAlias.MinorSeventhMajor;

        public override string Description { get; }
            = "Description not added yet.";

        public override List<Interval> Notes
            => new List<Interval> { Fondamental, ThirdMinor, FifthPerfect, SeventhMajor };

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