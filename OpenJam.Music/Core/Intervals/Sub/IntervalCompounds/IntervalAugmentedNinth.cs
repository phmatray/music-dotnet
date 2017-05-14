using System;
using System.Collections.Generic;

namespace OpenJam.Music.Core
{
    public class IntervalAugmentedNinth
        : IntervalCompound
    {
        public IntervalAugmentedNinth()
        {
        }

        public IntervalAugmentedNinth(Pitch startingPitch)
            : base(startingPitch)
        {
        }

        public override IntervalAlias IntervalAlias { get; }
            = IntervalAlias.AugmentedNinth;

        public override IntervalConsonance HarmonicConsonance { get; }
            = IntervalConsonance.Dissonante;

        public override List<string> Names { get; }
            = new List<string> { "Augmented Ninth" };

        public override List<string> Abbreviations { get; }
            = new List<string> { "A9", "+9", "Aug. 9" };

        public override string QualityComposition { get; }
            = "1 octave et 1 ton et 1 demi-ton chromatique";

        public override int Semitones { get; }
            = 15;

        public override DiatonicInterval DiatonicInterval { get; }
            = new DiatonicIntervalNinth();

        public override IntervalModifier IntervalModifier { get; }
            = new IntervalModifierAugmented();

        public override IntervalSpanning Spanning { get; }
            = IntervalSpanning.Compound;

        public override Uri WikipediaUrl { get; }
            = new Uri("https://en.wikipedia.org/wiki/Ninth#Augmented_ninth");

        public override string WikipediaDescription { get; }
            = @"An augmented ninth is a compound musical interval spanning 15 semitones, or 3 semitones above an octave. Enharmonically equivalent to a compound minor third, if transposed into a single octave, it becomes a minor third or major sixth. It is a consonant interval.";

        public override string ToString()
            => Abbreviation;
    }
}