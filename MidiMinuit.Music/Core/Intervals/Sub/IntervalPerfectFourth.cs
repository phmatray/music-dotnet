using System;
using System.Collections.Generic;

namespace MidiMinuit.Music.Core
{
    public class IntervalPerfectFourth
        : Interval
    {
        public IntervalPerfectFourth()
        {
        }

        public IntervalPerfectFourth(Pitch lowerPitch)
            : base(lowerPitch)
        {
        }

        public override IntervalAlias Alias { get; }
            = IntervalAlias.PerfectFourth;

        public override IntervalConsonance HarmonicConsonance { get; }
            = IntervalConsonance.Mixte;

        public override List<string> Names { get; }
            = new List<string> { "Perfect Fourth", "Diatessaron" };

        public override List<string> Abbreviations { get; }
            = new List<string> { "P4", "Perf. 4" };

        public override string QualityComposition { get; }
            = "2 tons et 1 demi-ton diatonique";

        public override int Semitones { get; }
            = 5;

        public override IntervalStep IntervalStep { get; }
            = new IntervalStepFourth();

        public override IntervalModifier IntervalModifier { get; }
            = new IntervalModifierPerfect();

        public override IntervalSpanning Spanning { get; }
            = IntervalSpanning.Simple;

        public override Uri WikipediaUrl { get; }
            = new Uri("https://en.wikipedia.org/wiki/Perfect_fourth");

        public override string WikipediaDescription { get; }
            = @"In classical music from Western culture, a fourth is a musical interval encompassing four staff positions, and the perfect fourth is a fourth spanning five semitones (half steps, or half tones). For example, the ascending interval from C to the next F is a perfect fourth, as the note F lies five semitones above C, and there are four staff positions from C to F. Diminished and augmented fourths span the same number of staff positions, but consist of a different number of semitones (four and six).

The perfect fourth may be derived from the harmonic series as the interval between the third and fourth harmonics. The term perfect identifies this interval as belonging to the group of perfect intervals, so called because they are neither major nor minor (unlike thirds, which are either minor or major) but perfect.";

        public override string ToString()
            => Abbreviation;

        public override Interval Clone()
            => MemberwiseClone() as Interval;
    }
}