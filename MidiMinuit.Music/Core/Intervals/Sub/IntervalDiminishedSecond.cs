using System;
using System.Collections.Generic;

namespace MidiMinuit.Music.Core
{
    public class IntervalDiminishedSecond
        : Interval
    {
        public IntervalDiminishedSecond()
        {
        }

        public IntervalDiminishedSecond(Pitch lowerPitch)
            : base(lowerPitch)
        {
        }

        public override IntervalAlias Alias { get; }
            = IntervalAlias.DiminishedSecond;

        public override IntervalConsonance HarmonicConsonance { get; }
            = IntervalConsonance.Parfaite;

        public override List<string> Names { get; }
            = new List<string> { "Diminished Second" };

        public override List<string> Abbreviations { get; }
            = new List<string> { "d2", "°2", "deg. 2", "dim. 2" };

        public override string QualityComposition { get; }
            = "NO DATA";

        public override int Semitones { get; }
            = 0;

        public override DiatonicInterval DiatonicInterval { get; }
            = new DiatonicIntervalSecond();

        public override IntervalModifier IntervalModifier { get; }
            = new IntervalModifierDiminished();

        public override IntervalSpanning Spanning { get; }
            = IntervalSpanning.Simple;

        public override Uri WikipediaUrl { get; }
            = new Uri("https://en.wikipedia.org/wiki/Diminished_second");

        public override string WikipediaDescription { get; }
            = @"In modern Western tonal music theory, a diminished second is the interval produced by narrowing a minor second by one chromatic semitone. It is enharmonically equivalent to a perfect unison. Thus, it is the interval between notes on two adjacent staff positions, or having adjacent note letters, altered in such a way that they have no pitch difference in twelve-tone equal temperament. An example is the interval from a B to the C♭ immediately above; another is the interval from a B♯ to the C immediately above.";

        public override string ToString()
            => Abbreviation;

        public override Interval Clone()
            => MemberwiseClone() as Interval;
    }
}