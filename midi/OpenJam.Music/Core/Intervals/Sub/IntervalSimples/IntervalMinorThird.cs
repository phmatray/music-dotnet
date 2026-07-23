using System;
using System.Collections.Generic;

namespace OpenJam.Music.Core
{
    public class IntervalMinorThird
        : IntervalSimple
    {
        public IntervalMinorThird()
        {
        }

        public IntervalMinorThird(Pitch startingPitch)
            : base(startingPitch)
        {
        }

        public override IntervalAlias IntervalAlias { get; }
            = IntervalAlias.MinorThird;

        public override IntervalConsonance HarmonicConsonance { get; }
            = IntervalConsonance.Imparfaite;

        public override List<string> Names { get; }
            = new List<string> { "Minor Third" };

        public override List<string> Abbreviations { get; }
            = new List<string> { "m3", "min. 3" };

        public override string QualityComposition { get; }
            = "1 ton et 1 demi-ton diatonique";

        public override int Semitones { get; }
            = 3;

        public override DiatonicInterval DiatonicInterval { get; }
            = new DiatonicIntervalThird();

        public override IntervalModifier IntervalModifier { get; }
            = new IntervalModifierMinor();

        public override IntervalSpanning Spanning { get; }
            = IntervalSpanning.Simple;

        public override Uri WikipediaUrl { get; }
            = new Uri("https://en.wikipedia.org/wiki/Minor_third");

        public override string WikipediaDescription { get; }
            = @"In the music theory of Western culture, a minor third is a musical interval that encompasses three half steps, or semitones. Staff notation represents the minor third as encompassing three staff positions. The minor third is one of two commonly occurring thirds. It is called minor because it is the smaller of the two: the major third spans an additional semitone. For example, the interval from A to C is a minor third, as the note C lies three semitones above A, and (coincidentally) there are three staff positions from A to C. Diminished and augmented thirds span the same number of staff positions, but consist of a different number of semitones (two and five). The minor third is a skip melodically.";

        public override string ToString()
            => Abbreviation;
    }
}