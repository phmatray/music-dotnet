using System.Collections.Generic;
using ConsoleApp1.IntervalModifiers;
using ConsoleApp1.Intervals;

namespace ConsoleApp1.IntervalQualities
{
    public class IntervalAugmentedSixth : Interval
    {
        public override IntervalQuality Quality { get; }
            = IntervalQuality.IntervalAugmentedSixth;

        public override List<string> QualityName { get; }
            = new List<string> { "Augmented Sixth" };

        public override List<string> QualityAbbreviation { get; }
            = new List<string> { "A6", "+6" };

        public override List<string> QualityAbbreviation2 { get; }
            = new List<string> { "Aug. 6" };

        public override string QualityComposition { get; }
            = "4 tons, 1 demi-ton diatonique et 1 demi-ton chromatique";

        public override int Semitones { get; } 
            = 10;

        public override IntervalNumber Number { get; } 
            = IntervalNumber.Sixth;

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