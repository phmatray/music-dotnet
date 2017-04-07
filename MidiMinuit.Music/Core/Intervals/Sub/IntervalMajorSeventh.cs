using System;
using System.Collections.Generic;

namespace MidiMinuit.Music.Core
{
    public class IntervalMajorSeventh
        : Interval
    {
        public IntervalMajorSeventh()
        {
        }

        public IntervalMajorSeventh(Pitch lowerPitch)
            : base(lowerPitch)
        {
        }

        public override IntervalAlias Alias { get; }
            = IntervalAlias.MajorSeventh;

        public override IntervalConsonance HarmonicConsonance { get; }
            = IntervalConsonance.Dissonante;

        public override List<string> Names { get; }
            = new List<string> { "Major Seventh", "Supermajor Seventh" };

        public override List<string> Abbreviations { get; }
            = new List<string> { "M7", "Maj. 7" };

        public override string QualityComposition { get; }
            = "5 tons et 1 demi-ton diatonique";

        public override int Semitones { get; }
            = 11;

        public override IntervalStep IntervalStep { get; }
            = new IntervalStepSeventh();

        public override IntervalModifier IntervalModifier { get; }
            = new IntervalModifierMajor();

        public override IntervalSpanning Spanning { get; }
            = IntervalSpanning.Simple;

        public override Uri WikipediaUrl { get; }
            = new Uri("https://en.wikipedia.org/wiki/Major_seventh");

        public override string WikipediaDescription { get; }
            = @"In classical music from Western culture, a seventh is a musical interval encompassing seven staff positions, and the major seventh is one of two commonly occurring sevenths. It is qualified as major because it is the larger of the two. The major seventh spans eleven semitones, its smaller counterpart being the minor seventh, spanning ten semitones. For example, the interval from C to B is a major seventh, as the note B lies eleven semitones above C, and there are seven staff positions from C to B. Diminished and augmented sevenths span the same number of staff positions, but consist of a different number of semitones (nine and twelve).";

        public override string ToString()
            => Abbreviation;

        public override Interval Clone()
            => MemberwiseClone() as Interval;
    }
}