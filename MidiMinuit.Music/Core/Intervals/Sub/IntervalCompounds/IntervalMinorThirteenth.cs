using System;
using System.Collections.Generic;

namespace MidiMinuit.Music.Core
{
    public class IntervalMinorThirteenth
        : IntervalCompound
    {
        public IntervalMinorThirteenth()
        {
        }

        public IntervalMinorThirteenth(Pitch startingPitch)
            : base(startingPitch)
        {
        }

        public override IntervalAlias IntervalAlias { get; }
            = IntervalAlias.MinorThirteenth;

        public override IntervalConsonance HarmonicConsonance { get; }
            = IntervalConsonance.Imparfaite;

        public override List<string> Names { get; }
            = new List<string> { "Minor Thirteenth" };

        public override List<string> Abbreviations { get; }
            = new List<string> { "m13", "min. 13" };

        public override string QualityComposition { get; }
            = "1 octave et 3 tons et 2 demi-tons diatoniques";

        public override int Semitones { get; }
            = 20;

        public override DiatonicInterval DiatonicInterval { get; }
            = new DiatonicIntervalThirteenth();

        public override IntervalModifier IntervalModifier { get; }
            = new IntervalModifierMinor();

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