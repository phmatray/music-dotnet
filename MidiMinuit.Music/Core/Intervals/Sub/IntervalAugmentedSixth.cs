using System;
using System.Collections.Generic;

namespace MidiMinuit.Music.Core
{
    public class IntervalAugmentedSixth
        : Interval
    {
        public IntervalAugmentedSixth()
        {
        }

        public IntervalAugmentedSixth(Pitch lowerPitch)
            : base(lowerPitch)
        {
        }

        public override IntervalAlias IntervalAlias { get; }
            = IntervalAlias.AugmentedSixth;

        public override IntervalConsonance HarmonicConsonance { get; }
            = IntervalConsonance.Dissonante;

        public override List<string> Names { get; }
            = new List<string> { "Augmented Sixth" };

        public override List<string> Abbreviations { get; }
            = new List<string> { "A6", "+6", "Aug. 6" };

        public override string QualityComposition { get; }
            = "4 tons, 1 demi-ton diatonique et 1 demi-ton chromatique";

        public override int Semitones { get; }
            = 10;

        public override DiatonicInterval DiatonicInterval { get; }
            = new DiatonicIntervalSixth();

        public override IntervalModifier IntervalModifier { get; }
            = new IntervalModifierAugmented();

        public override IntervalSpanning Spanning { get; }
            = IntervalSpanning.Simple;

        public override Uri WikipediaUrl { get; }
            = new Uri("https://en.wikipedia.org/wiki/Augmented_sixth");

        public override string WikipediaDescription { get; }
            = @"In classical music from Western culture, an augmented sixth is an interval produced by widening a major sixth by a chromatic semitone. For instance, the interval from C to A is a major sixth, nine semitones wide, and both the intervals from C♭ to A, and from C to A♯ are augmented sixths, spanning ten semitones. Being augmented, it is considered a dissonant interval.

Its inversion is the diminished third, and its enharmonic equivalent is the minor seventh.";

        public override string ToString()
            => Abbreviation;
    }
}