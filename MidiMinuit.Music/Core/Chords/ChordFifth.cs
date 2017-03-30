using System;
using System.Collections.Generic;
using MidiMinuit.Music.Core.Intervals;
using MidiMinuit.Music.Core.Notes;

namespace MidiMinuit.Music.Core.Chords
{
    public class ChordFifth
        : Chord
    {
        public ChordFifth(Pitch fondamental)
        {
            if (fondamental == null)
            {
                throw new ArgumentNullException(nameof(fondamental));
            }

            Fondamental = new IntervalPerfectUnison(fondamental);
            FifthPerfect = new IntervalPerfectFifth(fondamental);
        }

        public IntervalPerfectUnison Fondamental { get; }

        public IntervalPerfectFifth FifthPerfect { get; }

        public override ChordAlias Alias { get; }
            = ChordAlias.Fifth;

        public override string Description { get; }
            = "Description not added yet.";

        public override List<Interval> Intervals
            => new List<Interval> { Fondamental, FifthPerfect };

        public override string Name
            => $"{Fondamental}5";

        public override string ToString()
            => Name;

        public override Chord Clone()
            => MemberwiseClone() as Chord;
    }
}