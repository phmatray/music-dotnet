using System;
using System.Collections.Generic;

namespace OpenJam.Music.Core
{
    public class IntervalPerfectEleventh
        : IntervalCompound
    {
        public IntervalPerfectEleventh()
        {
        }

        public IntervalPerfectEleventh(Pitch startingPitch)
            : base(startingPitch)
        {
        }

        public override IntervalAlias IntervalAlias { get; }
            = IntervalAlias.PerfectEleventh;

        public override IntervalConsonance HarmonicConsonance { get; }
            = IntervalConsonance.Mixte;

        public override List<string> Names { get; }
            = new List<string> { "Perfect Eleventh" };

        public override List<string> Abbreviations { get; }
            = new List<string> { "P11", "Perf. 11" };

        public override string QualityComposition { get; }
            = "1 octave et 2 tons et 1 demi-ton diatonique";

        public override int Semitones { get; }
            = 17;

        public override DiatonicInterval DiatonicInterval { get; }
            = new DiatonicIntervalEleventh();

        public override IntervalModifier IntervalModifier { get; }
            = new IntervalModifierPerfect();

        public override IntervalSpanning Spanning { get; }
            = IntervalSpanning.Compound;

        public override Uri WikipediaUrl { get; }
            = new Uri("https://en.wikipedia.org/wiki/Eleventh");

        public override string WikipediaDescription { get; }
            = @"In music or music theory an eleventh is the note eleven scale degrees from the root of a chord and also the interval between the root and the eleventh. The interval can be also described as a compound fourth, spanning an octave plus a fourth.";

        public override string ToString()
            => Abbreviation;
    }
}