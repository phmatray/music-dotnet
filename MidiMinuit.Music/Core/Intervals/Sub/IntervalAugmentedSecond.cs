using System;
using System.Collections.Generic;

namespace MidiMinuit.Music.Core
{
    public class IntervalAugmentedSecond
        : Interval
    {
        public IntervalAugmentedSecond()
        {
        }

        public IntervalAugmentedSecond(Pitch lowerPitch)
            : base(lowerPitch)
        {
        }

        public override IntervalAlias IntervalAlias { get; }
            = IntervalAlias.AugmentedSecond;

        public override IntervalConsonance HarmonicConsonance { get; }
            = IntervalConsonance.Dissonante;

        public override List<string> Names { get; }
            = new List<string> { "Augmented Second" };

        public override List<string> Abbreviations { get; }
            = new List<string> { "A2", "+2", "Aug. 2" };

        public override string QualityComposition { get; }
            = "1 ton et 1 demi-ton chromatique";

        public override int Semitones { get; }
            = 3;

        public override DiatonicInterval DiatonicInterval { get; }
            = new DiatonicIntervalSecond();

        public override IntervalModifier IntervalModifier { get; }
            = new IntervalModifierAugmented();

        public override IntervalSpanning Spanning { get; }
            = IntervalSpanning.Simple;

        public override Uri WikipediaUrl { get; }
            = new Uri("https://en.wikipedia.org/wiki/Augmented_second");

        public override string WikipediaDescription { get; }
            = @"In classical music from Western culture, an augmented second is an interval that is sonically equivalent to a minor third, spanning three semitones, and is created by widening a major second by a chromatic semitone. For instance, the interval from C to D is a major second, two semitones wide, and the interval from C to D♯ is an augmented second, spanning three semitones.

Augmented seconds occur in many scales, most important the harmonic minor and its various modes. They also occur in the various Gypsy scales (which consist almost entirely of augmented and minor seconds). In harmonic minor scales, the augmented second occurs between the sixth and seventh scale degrees. For example, in the scale of A harmonic minor, the notes F and G♯ form the interval of an augmented second. This distinguishing feature of harmonic minor scales occurs as a consequence of the seventh scale degree having been chromatically raised in order to allow chords in a minor key to follow the same rules of cadence observed in major keys, where the V chord is ""dominant"" (that is, contains a major triad plus a minor seventh).";

        public override string ToString()
            => Abbreviation;
    }
}