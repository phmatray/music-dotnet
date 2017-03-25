namespace MidiMinuit.Lib.Core.Chords
{
    using System;
    using System.Collections.Generic;
    using Intervals;
    using Notes;

    public class ChordSuspendedFourth
        : Chord
    {
        public ChordSuspendedFourth(Note fondamental)
        {
            if (fondamental == null)
            {
                throw new ArgumentNullException(nameof(fondamental));
            }

            Fondamental = new IntervalPerfectUnison(fondamental);
            FourthPerfect = new IntervalPerfectFourth(fondamental);
            FifthPerfect = new IntervalPerfectFifth(fondamental);
        }

        public IntervalPerfectUnison Fondamental { get; }

        public IntervalPerfectFourth FourthPerfect { get; }

        public IntervalPerfectFifth FifthPerfect { get; }

        public override ChordAlias Alias { get; }
            = ChordAlias.SuspendedFourth;

        public override string Description { get; }
            = "Description not added yet.";

        public override List<Interval> Intervals
            => new List<Interval> { Fondamental, FourthPerfect, FifthPerfect };

        public override string Name
            => $"{Fondamental}sus4";

        public override string ToString()
            => Name;

        public override Chord Clone()
            => MemberwiseClone() as Chord;
    }
}