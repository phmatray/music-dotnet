using System;
using System.Collections.Generic;

namespace MidiMinuit.Music.Core
{
    public class IntervalPerfectUnison
        : Interval
    {
        public IntervalPerfectUnison()
        {
        }

        public IntervalPerfectUnison(Pitch startingPitch)
            : base(startingPitch)
        {
        }

        public override IntervalAlias IntervalAlias { get; }
            = IntervalAlias.PerfectUnison;

        public override IntervalConsonance HarmonicConsonance { get; }
            = IntervalConsonance.Parfaite;

        public override List<string> Names { get; }
            = new List<string> { "Perfect Unison", "Prime", "Perfect Prime" };

        public override List<string> Abbreviations { get; }
            = new List<string> { "P1", "Perf. 1" };

        public override string QualityComposition { get; }
            = "NO DATA";

        public override int Semitones { get; }
            = 0;

        public override DiatonicInterval DiatonicInterval { get; }
            = new DiatonicIntervalUnison();

        public override IntervalModifier IntervalModifier { get; }
            = new IntervalModifierPerfect();

        public override IntervalSpanning Spanning { get; }
            = IntervalSpanning.Simple;

        public override Uri WikipediaUrl { get; }
            = new Uri("https://en.wikipedia.org/wiki/Unison");

        public override string WikipediaDescription { get; }
            = "NO DATA";

        public override string ToString()
            => Abbreviation;
    }
}