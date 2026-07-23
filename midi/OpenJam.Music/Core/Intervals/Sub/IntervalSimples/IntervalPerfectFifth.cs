using System;
using System.Collections.Generic;

namespace OpenJam.Music.Core
{
    public class IntervalPerfectFifth
        : IntervalSimple
    {
        public IntervalPerfectFifth()
        {
        }

        public IntervalPerfectFifth(Pitch startingPitch)
            : base(startingPitch)
        {
        }

        public override IntervalAlias IntervalAlias { get; }
            = IntervalAlias.PerfectFifth;

        public override IntervalConsonance HarmonicConsonance { get; }
            = IntervalConsonance.Parfaite;

        public override List<string> Names { get; }
            = new List<string> { "Perfect Fifth", "Diapente" };

        public override List<string> Abbreviations { get; }
            = new List<string> { "P5", "Perf. 5" };

        public override string QualityComposition { get; }
            = "3 tons et 1 demi-ton diatonique";

        public override int Semitones { get; }
            = 7;

        public override DiatonicInterval DiatonicInterval { get; }
            = new DiatonicIntervalFifth();

        public override IntervalModifier IntervalModifier { get; }
            = new IntervalModifierPerfect();

        public override IntervalSpanning Spanning { get; }
            = IntervalSpanning.Simple;

        public override Uri WikipediaUrl { get; }
            = new Uri("https://en.wikipedia.org/wiki/Perfect_fifth");

        public override string WikipediaDescription { get; }
            = @"In music theory, a perfect fifth is the musical interval corresponding to a pair of pitches with a frequency ratio of 3:2, or very nearly so.

In classical music from Western culture, a fifth is the interval from the first to the last of five consecutive notes in a diatonic scale. The perfect fifth (often abbreviated P5) spans seven semitones, while the diminished fifth spans six and the augmented fifth spans eight semitones. For example, the interval from C to G is a perfect fifth, as the note G lies seven semitones above C.";

        public override string ToString()
            => Abbreviation;
    }
}