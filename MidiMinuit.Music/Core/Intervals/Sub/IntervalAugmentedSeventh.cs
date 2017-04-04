using System;
using System.Collections.Generic;
using MidiMinuit.Music.Core.IntervalModifiers;
using MidiMinuit.Music.Core.IntervalSteps;
using MidiMinuit.Music.Core.Pitches;

namespace MidiMinuit.Music.Core.Intervals
{
    public class IntervalAugmentedSeventh
        : Interval
    {
        public IntervalAugmentedSeventh()
        {
        }

        public IntervalAugmentedSeventh(Pitch lowerPitch)
            : base(lowerPitch)
        {
        }

        public override IntervalAlias Alias { get; }
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

        public override IntervalStep Step { get; }
            = new IntervalStepSeventh();

        public override IntervalModifier Modifier { get; }
            = new IntervalModifierAugmented();

        public override IntervalSpanning Spanning { get; }
            = IntervalSpanning.Simple;

        public override Uri WikipediaUrl { get; }
            = new Uri("https://en.wikipedia.org/wiki/Augmented_seventh");

        public override string WikipediaDescription { get; }
            = @"In classical music from Western culture, an augmented seventh is an interval produced by widening a major seventh by a chromatic semitone. For instance, the interval from C to B is a major seventh, eleven semitones wide, and both the intervals from C♭ to B, and from C to B♯ are augmented sevenths, spanning twelve semitones. Being augmented, it is classified as a dissonant interval. However, it is enharmonically equivalent to the perfect octave.";

        public override string ToString()
            => Abbreviation;

        public override Interval Clone()
            => MemberwiseClone() as Interval;
    }
}