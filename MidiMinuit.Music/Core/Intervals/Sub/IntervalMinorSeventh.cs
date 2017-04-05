using System;
using System.Collections.Generic;

namespace MidiMinuit.Music.Core
{
    public class IntervalMinorSeventh
        : Interval
    {
        public IntervalMinorSeventh()
        {
        }

        public IntervalMinorSeventh(Pitch lowerPitch)
            : base(lowerPitch)
        {
        }

        public override IntervalAlias Alias { get; }
            = IntervalAlias.MinorSeventh;

        public override IntervalConsonance HarmonicConsonance { get; }
            = IntervalConsonance.Dissonante;

        public override List<string> Names { get; }
            = new List<string> { "Minor Seventh" };

        public override List<string> Abbreviations { get; }
            = new List<string> { "m7", "min. 7" };

        public override string QualityComposition { get; }
            = "4 tons et 2 demi-tons diatoniques";

        public override int Semitones { get; }
            = 10;

        public override IntervalStep Step { get; }
            = new IntervalStepSeventh();

        public override IntervalModifier Modifier { get; }
            = new IntervalModifierMinor();

        public override IntervalSpanning Spanning { get; }
            = IntervalSpanning.Simple;

        public override Uri WikipediaUrl { get; }
            = new Uri("https://en.wikipedia.org/wiki/Minor_seventh");

        public override string WikipediaDescription { get; }
            = @"In the music of Western culture, a seventh is a musical interval encompassing seven staff positions, and the minor seventh is one of two commonly occurring sevenths. It is qualified as minor because it is the smaller of the two: the minor seventh spans ten semitones, the major seventh eleven. For example, the interval from A to G is a minor seventh, as the note G lies ten semitones above A, and there are seven staff positions from A to G. Diminished and augmented sevenths span the same number of staff positions, but consist of a different number of semitones (nine and twelve).";

        public override string ToString()
            => Abbreviation;

        public override Interval Clone()
            => MemberwiseClone() as Interval;
    }
}