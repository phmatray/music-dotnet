using System;
using System.Collections.Generic;

namespace MidiMinuit.Music.Core
{
    public class IntervalDiminishedSixth
        : Interval
    {
        public IntervalDiminishedSixth()
        {
        }

        public IntervalDiminishedSixth(Pitch lowerPitch)
            : base(lowerPitch)
        {
        }

        public override IntervalAlias IntervalAlias { get; }
            = IntervalAlias.DiminishedSixth;

        public override IntervalConsonance HarmonicConsonance { get; }
            = IntervalConsonance.Dissonante;

        public override List<string> Names { get; }
            = new List<string> { "Diminished Sixth" };

        public override List<string> Abbreviations { get; }
            = new List<string> { "d6", "°6", "deg. 6", "dim. 6" };

        public override string QualityComposition { get; }
            = "2 tons et 3 demi-tons diatoniques";

        public override int Semitones { get; }
            = 7;

        public override DiatonicInterval DiatonicInterval { get; }
            = new DiatonicIntervalSixth();

        public override IntervalModifier IntervalModifier { get; }
            = new IntervalModifierDiminished();

        public override IntervalSpanning Spanning { get; }
            = IntervalSpanning.Simple;

        public override Uri WikipediaUrl { get; }
            = new Uri("https://en.wikipedia.org/wiki/Diminished_sixth");

        public override string WikipediaDescription { get; }
            = @"In classical music from Western culture, a diminished sixth is an interval produced by narrowing a minor sixth by a chromatic semitone. For example, the interval from A to F is a minor sixth, eight semitones wide, and both the intervals from A♯ to F, and from A to F♭ are diminished sixths, spanning seven semitones. Being diminished, it is considered a dissonant interval.

Its inversion is the augmented third, and its enharmonic equivalent is the perfect fifth.";

        public override string ToString()
            => Abbreviation;
    }
}