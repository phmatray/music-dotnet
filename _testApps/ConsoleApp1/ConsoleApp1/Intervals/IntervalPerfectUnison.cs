using System.Collections.Generic;
using ConsoleApp1.IntervalModifiers;
using ConsoleApp1.IntervalNumbers;

namespace ConsoleApp1.Intervals
{
    public class IntervalPerfectUnison : Interval
    {
        public override IntervalQuality Quality { get; }
            = IntervalQuality.IntervalPerfectUnison;

        public override IntervalConsonance HarmonicConsonance { get; }
            = IntervalConsonance.Parfaite;

        public override List<string> QualityName { get; }
            = new List<string> { "Perfect Unison", "Prime", "Perfect Prime" };

        public override List<string> QualityAbbreviation { get; }
            = new List<string> { "P1" };

        public override List<string> QualityAbbreviation2 { get; }
            = new List<string> { "Perf. 1" };

        public override string QualityComposition { get; }
            = "NO DATA";

        public override int Semitones { get; }
            = 0;

        public override IntervalNumber Number { get; }
            = new IntervalNumberUnison();

        public override IntervalModifier Modifier { get; }
            = new IntervalModifierPerfect();

        public override IntervalSpanning Spanning { get; }
            = IntervalSpanning.Simple;

        public override string ToString()
            => Abbreviation;

        public override Interval Clone()
            => MemberwiseClone() as Interval;
    }
}