using System;
using System.Collections.Generic;

namespace OpenJam.Music.Core
{
    public class IntervalDiminishedThird
        : IntervalSimple
    {
        public IntervalDiminishedThird()
        {
        }

        public IntervalDiminishedThird(Pitch startingPitch)
            : base(startingPitch)
        {
        }

        public override IntervalAlias IntervalAlias { get; }
            = IntervalAlias.DiminishedThird;

        public override IntervalConsonance HarmonicConsonance { get; }
            = IntervalConsonance.Dissonante;

        public override List<string> Names { get; }
            = new List<string> { "Diminished Third" };

        public override List<string> Abbreviations { get; }
            = new List<string> { "d3", "°3", "deg. 3", "dim. 3" };

        public override string QualityComposition { get; }
            = "2 demi-tons diatoniques";

        public override int Semitones { get; }
            = 2;

        public override DiatonicInterval DiatonicInterval { get; }
            = new DiatonicIntervalThird();

        public override IntervalModifier IntervalModifier { get; }
            = new IntervalModifierDiminished();

        public override IntervalSpanning Spanning { get; }
            = IntervalSpanning.Simple;

        public override Uri WikipediaUrl { get; }
            = new Uri("https://en.wikipedia.org/wiki/Diminished_third");

        public override string WikipediaDescription { get; }
            = @"In classical music from Western culture, a diminished third is the musical interval produced by narrowing a minor third by a chromatic semitone. For instance, the interval from A to C is a minor third, three semitones wide, and both the intervals from A♯ to C, and from A to C♭ are diminished thirds, two semitones wide. Being diminished, it is considered a dissonant interval.";

        public override string ToString()
            => Abbreviation;
    }
}