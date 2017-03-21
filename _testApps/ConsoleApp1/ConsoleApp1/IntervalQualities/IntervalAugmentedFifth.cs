using System.Collections.Generic;
using ConsoleApp1.IntervalModifiers;
using ConsoleApp1.IntervalNumbers;

namespace ConsoleApp1.IntervalQualities
{
    public class IntervalAugmentedFifth
        : Interval
    {
        public override IntervalQuality Quality { get; }
            = IntervalQuality.IntervalAugmentedFifth;

        public override List<string> QualityName { get; }
            = new List<string> { "Augmented Fifth" };

        public override List<string> QualityAbbreviation { get; }
            = new List<string> { "A5", "+5" };

        public override List<string> QualityAbbreviation2 { get; }
            = new List<string> { "Aug. 5" };

        public override string QualityComposition { get; }
            = "3 tons, 1 demi-ton diatonique et 1 demi-ton chromatique";

        public override int Semitones { get; } 
            = 8;

        public override IntervalNumber Number { get; } 
            = new IntervalNumberFifth();

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