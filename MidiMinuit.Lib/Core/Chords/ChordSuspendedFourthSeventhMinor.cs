namespace MidiMinuit.Lib.Core.Chords
{
    using System;
    using System.Collections.Generic;
    using Intervals;
    using Notes;

    public class ChordSuspendedFourthSeventhMinor
        : Chord
    {
        public ChordSuspendedFourthSeventhMinor(Note fondamental)
        {
            if (fondamental == null)
            {
                throw new ArgumentNullException(nameof(fondamental));
            }

            Fondamental = new IntervalPerfectUnison(fondamental);
            FourthPerfect = new IntervalPerfectFourth(fondamental);
            FifthPerfect = new IntervalPerfectFifth(fondamental);
            SeventhMinor = new IntervalMinorSeventh(fondamental);
        }

        public IntervalPerfectUnison Fondamental { get; }

        public IntervalPerfectFourth FourthPerfect { get; }

        public IntervalPerfectFifth FifthPerfect { get; }

        public IntervalMinorSeventh SeventhMinor { get; }

        public override ChordAlias Alias { get; }
            = ChordAlias.SuspendedFourthSeventhMinor;

        public override string Description { get; }
            = "Description not added yet.";

        public override List<Interval> Intervals
            => new List<Interval> { Fondamental, FourthPerfect, FifthPerfect, SeventhMinor };

        public override string Name
            => $"{Fondamental}7sus4";

        public override string ToString()
            => Name;

        public override Chord Clone()
            => MemberwiseClone() as Chord;
    }
}