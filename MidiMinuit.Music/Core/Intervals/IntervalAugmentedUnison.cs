using System;
using System.Collections.Generic;
using MidiMinuit.Music.Core.IntervalModifiers;
using MidiMinuit.Music.Core.IntervalNumbers;
using MidiMinuit.Music.Core.Notes;

namespace MidiMinuit.Music.Core.Intervals
{
    public class IntervalAugmentedUnison
        : Interval
    {
        public IntervalAugmentedUnison()
        {
        }

        public IntervalAugmentedUnison(Pitch lowerPitch)
            : base(lowerPitch)
        {
        }

        public override IntervalAlias Alias { get; }
            = IntervalAlias.IntervalAugmentedUnison;

        public override IntervalConsonance HarmonicConsonance { get; }
            = IntervalConsonance.Dissonante;

        public override List<string> Names { get; }
            = new List<string> { "Augmented Unison", "Chromatic Semitone", "Minor Semitone" };

        public override List<string> Abbreviations { get; }
            = new List<string> { "A1", "+1", "Aug. 1" };

        public override string QualityComposition { get; }
            = "NO DATA";

        public override int Semitones { get; }
            = 1;

        public override IntervalStep Step { get; }
            = new IntervalStepUnison();

        public override IntervalModifier Modifier { get; }
            = new IntervalModifierAugmented();

        public override IntervalSpanning Spanning { get; }
            = IntervalSpanning.Simple;

        public override Uri WikipediaUrl { get; }
            = new Uri("https://en.wikipedia.org/wiki/Augmented_unison");

        public override string WikipediaDescription { get; }
            = "In modern Western tonal music theory an augmented unison or augmented prime is the interval between two notes on the same staff position, or denoted by the same note letter, whose alterations cause them, in ordinary equal temperament, to be one semitone apart. In other words, it is a unison where one note has been altered by a half-step, such as B♭ and B♮ or C♮ and C♯. The interval is often described as a chromatic semitone.";

        public override string ToString()
            => Abbreviation;

        public override Interval Clone()
            => MemberwiseClone() as Interval;
    }
}