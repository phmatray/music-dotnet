using System;
using System.Collections.Generic;

namespace OpenJam.Music.Core
{
    public class IntervalAugmentedFifth
        : IntervalSimple
    {
        public IntervalAugmentedFifth()
        {
        }

        public IntervalAugmentedFifth(Pitch startingPitch)
            : base(startingPitch)
        {
        }

        public override IntervalAlias IntervalAlias { get; }
            = IntervalAlias.AugmentedFifth;

        public override IntervalConsonance HarmonicConsonance { get; }
            = IntervalConsonance.Dissonante;

        public override List<string> Names { get; }
            = new List<string> { "Augmented Fifth" };

        public override List<string> Abbreviations { get; }
            = new List<string> { "A5", "+5", "Aug. 5" };

        public override string QualityComposition { get; }
            = "3 tons, 1 demi-ton diatonique et 1 demi-ton chromatique";

        public override int Semitones { get; }
            = 8;

        public override DiatonicInterval DiatonicInterval { get; }
            = new DiatonicIntervalFifth();

        public override IntervalModifier IntervalModifier { get; }
            = new IntervalModifierAugmented();

        public override IntervalSpanning Spanning { get; }
            = IntervalSpanning.Simple;

        public override Uri WikipediaUrl { get; }
            = new Uri("https://en.wikipedia.org/wiki/Augmented_fifth");

        public override string WikipediaDescription { get; }
            = @"In classical music from Western culture, an augmented fifth is an interval produced by widening a perfect fifth by a chromatic semitone. For instance, the interval from C to G is a perfect fifth, seven semitones wide, and both the intervals from C♭ to G, and from C to G♯ are augmented fifths, spanning eight semitones. Being augmented, it is considered a dissonant interval.

Its inversion is the diminished fourth, and its enharmonic equivalent is the minor sixth.";

        public override string ToString()
            => Abbreviation;
    }
}