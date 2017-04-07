using System;
using System.Collections.Generic;

namespace MidiMinuit.Music.Core
{
    public class IntervalAugmentedOctave
        : Interval
    {
        public IntervalAugmentedOctave()
        {
        }

        public IntervalAugmentedOctave(Pitch lowerPitch)
            : base(lowerPitch)
        {
        }

        public override IntervalAlias Alias { get; }
            = IntervalAlias.AugmentedOctave;

        public override IntervalConsonance HarmonicConsonance { get; }
            = IntervalConsonance.Dissonante;

        public override List<string> Names { get; }
            = new List<string> { "Augmented Octave", "Augmented Eighth" };

        public override List<string> Abbreviations { get; }
            = new List<string> { "A8", "+8", "Aug. 8" };

        public override string QualityComposition { get; }
            = "5 tons et 3 demi-tons diatoniques";

        public override int Semitones { get; }
            = 13;

        public override IntervalStep IntervalStep { get; }
            = new IntervalStepOctave();

        public override IntervalModifier IntervalModifier { get; }
            = new IntervalModifierAugmented();

        public override IntervalSpanning Spanning { get; }
            = IntervalSpanning.Simple;

        public override Uri WikipediaUrl { get; }
            = new Uri("https://en.wikipedia.org/wiki/Augmented_octave");

        public override string WikipediaDescription { get; }
            = @"In modern Western tonal music theory an augmented octave is the sum of a perfect octave and an augmented unison or chromatic semitone. It is the interval between two notes, with the same note letter on staff positions an octave apart, whose alterations cause them, in ordinary equal temperament, to be thirteen semitones apart. In other words, it is a perfect octave which has been widened by a half-step, such as B♭ and B♮ or C and C♯; it is a compound augmented unison. It is the enharmonic equivalent of a minor ninth.";

        public override string ToString()
            => Abbreviation;

        public override Interval Clone()
            => MemberwiseClone() as Interval;
    }
}