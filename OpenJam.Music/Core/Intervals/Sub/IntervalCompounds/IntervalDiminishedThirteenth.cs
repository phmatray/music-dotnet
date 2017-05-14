using System;
using System.Collections.Generic;

namespace OpenJam.Music.Core
{
    public class IntervalDiminishedThirteenth
        : IntervalCompound
    {
        public IntervalDiminishedThirteenth()
        {
        }

        public IntervalDiminishedThirteenth(Pitch startingPitch)
            : base(startingPitch)
        {
        }

        public override IntervalAlias IntervalAlias { get; }
            = IntervalAlias.DiminishedThirteenth;

        public override IntervalConsonance HarmonicConsonance { get; }
            = IntervalConsonance.Dissonante;

        public override List<string> Names { get; }
            = new List<string> { "Diminished Thirteenth" };

        public override List<string> Abbreviations { get; }
            = new List<string> { "d13", "°13", "deg. 13", "dim. 13" };

        public override string QualityComposition { get; }
            = "1 octave et 2 tons et 3 demi-tons diatoniques";

        public override int Semitones { get; }
            = 19;

        public override DiatonicInterval DiatonicInterval { get; }
            = new DiatonicIntervalThirteenth();

        public override IntervalModifier IntervalModifier { get; }
            = new IntervalModifierDiminished();

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