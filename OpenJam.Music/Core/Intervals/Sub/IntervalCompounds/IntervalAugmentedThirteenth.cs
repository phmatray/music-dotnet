using System;
using System.Collections.Generic;

namespace OpenJam.Music.Core
{
    public class IntervalAugmentedThirteenth
        : IntervalCompound
    {
        public IntervalAugmentedThirteenth()
        {
        }

        public IntervalAugmentedThirteenth(Pitch startingPitch)
            : base(startingPitch)
        {
        }

        public override IntervalAlias IntervalAlias { get; }
            = IntervalAlias.AugmentedThirteenth;

        public override IntervalConsonance HarmonicConsonance { get; }
            = IntervalConsonance.Dissonante;

        public override List<string> Names { get; }
            = new List<string> { "Augmented Thirteenth" };

        public override List<string> Abbreviations { get; }
            = new List<string> { "A13", "+13", "Aug. 13" };

        public override string QualityComposition { get; }
            = "1 octave et 4 tons, 1 demi-ton diatonique et 1 demi-ton chromatique";

        public override int Semitones { get; }
            = 22;

        public override DiatonicInterval DiatonicInterval { get; }
            = new DiatonicIntervalThirteenth();

        public override IntervalModifier IntervalModifier { get; }
            = new IntervalModifierAugmented();

        public override IntervalSpanning Spanning { get; }
            = IntervalSpanning.Compound;

        public override Uri WikipediaUrl { get; }
            = new Uri("https://en.wikipedia.org/wiki/Thirteenth");

        public override string WikipediaDescription { get; }
            = @"In music or music theory, a thirteenth is the interval between the sixth and first scale degrees when the sixth is transposed up an octave, creating a compound sixth, or thirteenth. The thirteenth (an octave plus a sixth) is most commonly major or minor.";

        public override string ToString()
            => Abbreviation;
    }
}