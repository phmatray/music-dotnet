using System.Collections.Generic;
using ConsoleApp1.IntervalModifiers;
using ConsoleApp1.IntervalNumbers;

namespace ConsoleApp1.Intervals
{
    public class IntervalMajorThird : Interval
    {
        public override IntervalQuality Quality { get; }
            = IntervalQuality.IntervalMajorThird;

        public override IntervalConsonance HarmonicConsonance { get; }
            = IntervalConsonance.Imparfaite;

        public override List<string> QualityName { get; }
            = new List<string> { "Major Third" };

        public override List<string> QualityAbbreviation { get; }
            = new List<string> { "M3" };

        public override List<string> QualityAbbreviation2 { get; }
            = new List<string> { "Maj. 3" };

        public override string QualityComposition { get; }
            = "2 tons";

        public override int Semitones { get; } 
            = 4;

        public override IntervalNumber Number { get; } 
            = new IntervalNumberThird();

        public override IntervalModifier Modifier { get; } 
            = new IntervalModifierMajor();

        public override IntervalSpanning Spanning { get; } 
            = IntervalSpanning.Simple;

        public override string ToString() 
            => Abbreviation;

        public override Interval Clone() 
            => MemberwiseClone() as Interval;
    }
}