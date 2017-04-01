using System;
using System.Collections.Generic;
using MidiMinuit.Music.Core.IntervalModifiers;
using MidiMinuit.Music.Core.IntervalNumbers;
using MidiMinuit.Music.Core.Notes;

namespace MidiMinuit.Music.Core.Intervals
{
    public class IntervalMajorThird
        : Interval
    {
        public IntervalMajorThird()
        {
        }

        public IntervalMajorThird(Pitch lowerPitch)
            : base(lowerPitch)
        {
        }

        public override IntervalAlias Alias { get; }
            = IntervalAlias.IntervalMajorThird;

        public override IntervalConsonance HarmonicConsonance { get; }
            = IntervalConsonance.Imparfaite;

        public override List<string> Names { get; }
            = new List<string> { "Major Third" };

        public override List<string> Abbreviations { get; }
            = new List<string> { "M3", "Maj. 3" };

        public override string QualityComposition { get; }
            = "2 tons";

        public override int Semitones { get; }
            = 4;

        public override IntervalStep Step { get; }
            = new IntervalStepThird();

        public override IntervalModifier Modifier { get; }
            = new IntervalModifierMajor();

        public override IntervalSpanning Spanning { get; }
            = IntervalSpanning.Simple;

        public override Uri WikipediaUrl { get; }
            = new Uri("https://en.wikipedia.org/wiki/Major_third");

        public override string WikipediaDescription { get; }
            = @"In classical music from Western culture, a third is a musical interval encompassing three staff positions, and the major third is a third spanning four semitones. Along with the minor third, the major third is one of two commonly occurring thirds. It is qualified as major because it is the larger of the two: the major third spans four semitones, the minor third three. For example, the interval from C to E is a major third, as the note E lies four semitones above C, and there are three staff positions from C to E. Diminished and augmented thirds span the same number of staff positions, but consist of a different number of semitones (two and five).";

        public override string ToString()
            => Abbreviation;

        public override Interval Clone()
            => MemberwiseClone() as Interval;
    }
}