using System;
using System.Collections.Generic;

namespace OpenJam.Music.Core
{
    public class IntervalAugmentedEleventh
        : IntervalCompound
    {
        public IntervalAugmentedEleventh()
        {
        }

        public IntervalAugmentedEleventh(Pitch startingPitch)
            : base(startingPitch)
        {
        }

        public override IntervalAlias IntervalAlias { get; }
            = IntervalAlias.AugmentedEleventh;

        public override IntervalConsonance HarmonicConsonance { get; }
            = IntervalConsonance.Dissonante;

        public override List<string> Names { get; }
            = new List<string> { "Augmented Eleventh" };

        public override List<string> Abbreviations { get; }
            = new List<string> { "A11", "+11", "Aug. 11" };

        public override string QualityComposition { get; }
            = "NO DATA";

        public override int Semitones { get; }
            = 18;

        public override DiatonicInterval DiatonicInterval { get; }
            = new DiatonicIntervalEleventh();

        public override IntervalModifier IntervalModifier { get; }
            = new IntervalModifierAugmented();

        public override IntervalSpanning Spanning { get; }
            = IntervalSpanning.Compound;

        public override Uri WikipediaUrl { get; }
            = new Uri("https://en.wikipedia.org/wiki/Eleventh");

        public override string WikipediaDescription { get; }
            = @"In music or music theory an eleventh is the note eleven scale degrees from the root of a chord and also the interval between the root and the eleventh. The interval can be also described as a compound fourth, spanning an octave plus a fourth.

Since there are only seven degrees in a diatonic scale the eleventh degree is the same as the subdominant.

The eleventh is considered highly dissonant with the third.";

        public override string ToString()
            => Abbreviation;
    }
}