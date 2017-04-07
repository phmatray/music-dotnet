using System;
using System.Collections.Generic;

namespace MidiMinuit.Music.Core
{
    public class IntervalDiminishedFourth
        : Interval
    {
        public IntervalDiminishedFourth()
        {
        }

        public IntervalDiminishedFourth(Pitch lowerPitch)
            : base(lowerPitch)
        {
        }

        public override IntervalAlias IntervalAlias { get; }
            = IntervalAlias.DiminishedFourth;

        public override IntervalConsonance HarmonicConsonance { get; }
            = IntervalConsonance.Dissonante;

        public override List<string> Names { get; }
            = new List<string> { "Diminished Fourth" };

        public override List<string> Abbreviations { get; }
            = new List<string> { "d4", "°4", "deg. 4", "dim. 4" };

        public override string QualityComposition { get; }
            = "1 ton et 2 demi-tons diatoniques";

        public override int Semitones { get; }
            = 4;

        public override DiatonicInterval DiatonicInterval { get; }
            = new DiatonicIntervalFourth();

        public override IntervalModifier IntervalModifier { get; }
            = new IntervalModifierDiminished();

        public override IntervalSpanning Spanning { get; }
            = IntervalSpanning.Simple;

        public override Uri WikipediaUrl { get; }
            = new Uri("https://en.wikipedia.org/wiki/Diminished_fourth");

        public override string WikipediaDescription { get; }
            = @"In classical music from Western culture, a diminished fourth is an interval produced by narrowing a perfect fourth by a chromatic semitone. For example, the interval from C to F is a perfect fourth, five semitones wide, and both the intervals from C♯ to F, and from C to F♭ are diminished fourths, spanning four semitones. Being diminished, it is considered a dissonant interval.";

        public override string ToString()
            => Abbreviation;
    }
}