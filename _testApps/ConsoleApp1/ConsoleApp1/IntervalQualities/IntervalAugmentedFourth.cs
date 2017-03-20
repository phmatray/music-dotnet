using System.Collections.Generic;
using ConsoleApp1.IntervalModifiers;
using ConsoleApp1.Intervals;

namespace ConsoleApp1.IntervalQualities
{
    public class IntervalAugmentedFourth : Interval
    {
        public override IntervalQuality Quality { get; }
            = IntervalQuality.IntervalAugmentedFourth;

        public override List<string> QualityName { get; }
            = new List<string> { "Augmented Fourth", "Tritone" };

        public override List<string> QualityAbbreviation { get; }
            = new List<string> { "A4", "+4", "TT" };

        public override List<string> QualityAbbreviation2 { get; }
            = new List<string> { "Aug. 4" };

        public override string QualityComposition { get; }
            = "2 tons, 1 demi-ton diatonique et 1 demi-ton chromatique ou 3 tons(Triton)";

        public override int Semitones { get; } 
            = 6;

        public override IntervalNumber Number { get; } 
            = IntervalNumber.Fourth;

        public override IntervalModifier Modifier { get; } 
            =  new IntervalModifierAugmented();

        public override IntervalSpanning Spanning { get; } 
            = IntervalSpanning.Simple;

        public override string ToString() 
            => Abbreviation;

        public override Interval Clone() 
            => MemberwiseClone() as Interval;
    }
}