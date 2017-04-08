using System;
using System.Collections.Generic;

namespace MidiMinuit.Music.Core
{
    public class IntervalAugmentedThird
        : Interval
    {
        public IntervalAugmentedThird()
        {
        }

        public IntervalAugmentedThird(Pitch startingPitch)
            : base(startingPitch)
        {
        }

        public override IntervalAlias IntervalAlias { get; }
            = IntervalAlias.AugmentedThird;

        public override IntervalConsonance HarmonicConsonance { get; }
            = IntervalConsonance.Mixte;

        public override List<string> Names { get; }
            = new List<string> { "Augmented Third" };

        public override List<string> Abbreviations { get; }
            = new List<string> { "A3", "+3", "Aug. 3" };

        public override string QualityComposition { get; }
            = "2 tons et 1 demi-ton chromatique";

        public override int Semitones { get; }
            = 5;

        public override DiatonicInterval DiatonicInterval { get; }
            = new DiatonicIntervalThird();

        public override IntervalModifier IntervalModifier { get; }
            = new IntervalModifierAugmented();

        public override IntervalSpanning Spanning { get; }
            = IntervalSpanning.Simple;

        public override Uri WikipediaUrl { get; }
            = new Uri("https://en.wikipedia.org/wiki/Augmented_third");

        public override string WikipediaDescription { get; }
            = @"In classical music from Western culture, an augmented third is an interval of five semitones. It may be produced by widening a major third by a chromatic semitone. For instance, the interval from C to E is a major third, four semitones wide, and both the intervals from C♭ to E, and from C to E♯ are augmented thirds, spanning five semitones. Being augmented, it is considered a dissonant interval.

Its inversion is the diminished sixth, and its enharmonic equivalent is the perfect fourth.";

        public override string ToString()
            => Abbreviation;
    }
}