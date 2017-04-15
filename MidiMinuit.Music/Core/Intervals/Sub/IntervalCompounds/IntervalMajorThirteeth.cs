using System;
using System.Collections.Generic;

namespace MidiMinuit.Music.Core
{
    public class IntervalMajorThirteeth
        : IntervalCompound
    {
        public IntervalMajorThirteeth()
        {
        }

        public IntervalMajorThirteeth(Pitch startingPitch)
            : base(startingPitch)
        {
        }

        public override IntervalAlias IntervalAlias { get; }
            = IntervalAlias.MajorThirteenth;

        public override IntervalConsonance HarmonicConsonance { get; }
            = IntervalConsonance.Imparfaite;

        public override List<string> Names { get; }
            = new List<string> { "Major Thirteenth" };

        public override List<string> Abbreviations { get; }
            = new List<string> { "M13", "Maj. 13" };

        public override string QualityComposition { get; }
            = "1 octave et 4 tons et 1 demi-ton diatonique";

        public override int Semitones { get; }
            = 21;

        public override DiatonicInterval DiatonicInterval { get; }
            = new DiatonicIntervalThirteenth();

        public override IntervalModifier IntervalModifier { get; }
            = new IntervalModifierMajor();

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