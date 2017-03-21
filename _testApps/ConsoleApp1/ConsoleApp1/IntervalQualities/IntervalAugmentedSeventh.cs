using System.Collections.Generic;
using ConsoleApp1.IntervalModifiers;
using ConsoleApp1.IntervalNumbers;

namespace ConsoleApp1.IntervalQualities
{
    public class IntervalAugmentedSeventh : Interval
    {
        public override IntervalQuality Quality { get; }
            = IntervalQuality.IntervalAugmentedSeventh;

        public override List<string> QualityName { get; }
            = new List<string> { "Augmented Seventh" };

        public override List<string> QualityAbbreviation { get; }
            = new List<string> { "A7", "+7" };

        public override List<string> QualityAbbreviation2 { get; }
            = new List<string> { "Aug. 7" };

        public override string QualityComposition { get; }
            = "Inusitée dans la pratique";

        public override int Semitones { get; } 
            = 12;

        public override IntervalNumber Number { get; } 
            = new IntervalNumberSeventh();

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