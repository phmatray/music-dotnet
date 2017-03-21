using System.Collections.Generic;
using ConsoleApp1.IntervalModifiers;
using ConsoleApp1.IntervalNumbers;

namespace ConsoleApp1.IntervalQualities
{
    public class IntervalPerfectFourth : Interval
    {
        public override IntervalQuality Quality { get; }
            = IntervalQuality.IntervalPerfectFourth;

        public override List<string> QualityName { get; }
            = new List<string> { "Perfect Fourth", "Diatessaron" };

        public override List<string> QualityAbbreviation { get; }
            = new List<string> { "P4" };

        public override List<string> QualityAbbreviation2 { get; }
            = new List<string> { "Perf. 4" };

        public override string QualityComposition { get; }
            = "2 tons et 1 demi-ton diatonique";

        public override int Semitones { get; }
            = 5;

        public override IntervalNumber Number { get; } 
            = new IntervalNumberFourth();

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