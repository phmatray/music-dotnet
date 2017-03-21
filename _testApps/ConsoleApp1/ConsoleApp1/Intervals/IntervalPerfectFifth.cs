using System.Collections.Generic;
using ConsoleApp1.IntervalModifiers;
using ConsoleApp1.IntervalNumbers;

namespace ConsoleApp1.Intervals
{
    public class IntervalPerfectFifth : Interval
    {
        public override IntervalQuality Quality { get; }
            = IntervalQuality.IntervalPerfectFifth;

        public override IntervalConsonance HarmonicConsonance { get; }
            = IntervalConsonance.Parfaite;

        public override List<string> QualityName { get; }
            = new List<string> { "Perfect Fifth", "Diapente" };

        public override List<string> QualityAbbreviation { get; }
            = new List<string> { "P5" };

        public override List<string> QualityAbbreviation2 { get; }
            = new List<string> { "Perf. 5" };

        public override string QualityComposition { get; }
            = "3 tons et 1 demi-ton diatonique";

        public override int Semitones { get; } 
            = 7;

        public override IntervalNumber Number { get; } 
            = new IntervalNumberFifth();

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