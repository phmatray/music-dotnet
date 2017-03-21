using System.Collections.Generic;
using ConsoleApp1.IntervalModifiers;
using ConsoleApp1.IntervalNumbers;

namespace ConsoleApp1.IntervalQualities
{
    public class IntervalAugmentedSecond : Interval
    {
        public override IntervalQuality Quality { get; }
            = IntervalQuality.IntervalAugmentedSecond;

        public override List<string> QualityName { get; }
            = new List<string> { "Augmented Second" };

        public override List<string> QualityAbbreviation { get; }
            = new List<string> { "A2", "+2" };

        public override List<string> QualityAbbreviation2 { get; }
            = new List<string> { "Aug. 2" };

        public override string QualityComposition { get; }
            = "1 ton et 1 demi-ton chromatique";

        public override int Semitones { get; } 
            = 3;

        public override IntervalNumber Number { get; } 
            = new IntervalNumberSecond();

        public override IntervalModifier Modifier { get; } 
            = new IntervalModifierAugmented();

        public override IntervalSpanning Spanning { get; } 
            = IntervalSpanning.Simple;

        public override string ToString() 
            => Abbreviation;

        public override Interval Clone() 
            => MemberwiseClone() as Interval;
    }
}