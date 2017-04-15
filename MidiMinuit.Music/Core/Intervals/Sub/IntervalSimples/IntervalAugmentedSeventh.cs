using System;
using System.Collections.Generic;

namespace MidiMinuit.Music.Core
{
    public class IntervalAugmentedSeventh
        : IntervalSimple
    {
        public IntervalAugmentedSeventh()
        {
        }

        public IntervalAugmentedSeventh(Pitch startingPitch)
            : base(startingPitch)
        {
        }

        public override IntervalAlias IntervalAlias { get; }
            = IntervalAlias.AugmentedSeventh;

        public override IntervalConsonance HarmonicConsonance { get; }
            = IntervalConsonance.Parfaite;

        public override List<string> Names { get; }
            = new List<string> { "Augmented Seventh" };

        public override List<string> Abbreviations { get; }
            = new List<string> { "A7", "+7", "Aug. 7" };

        public override string QualityComposition { get; }
            = "Inusitée dans la pratique";

        public override int Semitones { get; }
            = 12;

        public override DiatonicInterval DiatonicInterval { get; }
            = new DiatonicIntervalSeventh();

        public override IntervalModifier IntervalModifier { get; }
            = new IntervalModifierAugmented();

        public override IntervalSpanning Spanning { get; }
            = IntervalSpanning.Simple;

        public override Uri WikipediaUrl { get; }
            = new Uri("https://en.wikipedia.org/wiki/Augmented_seventh");

        public override string WikipediaDescription { get; }
            = @"In classical music from Western culture, an augmented seventh is an interval produced by widening a major seventh by a chromatic semitone. For instance, the interval from C to B is a major seventh, eleven semitones wide, and both the intervals from C♭ to B, and from C to B♯ are augmented sevenths, spanning twelve semitones. Being augmented, it is classified as a dissonant interval. However, it is enharmonically equivalent to the perfect octave.";

        public override string ToString()
            => Abbreviation;
    }
}