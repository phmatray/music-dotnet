using System.Collections.Generic;
using ConsoleApp1.IntervalModifiers;
using ConsoleApp1.IntervalNumbers;

namespace ConsoleApp1.IntervalQualities
{
    public class IntervalMajorSeventh : Interval
    {
        public override IntervalQuality Quality { get; }
            = IntervalQuality.IntervalMajorSeventh;

        public override List<string> QualityName { get; }
            = new List<string> { "Major Seventh", "Supermajor Seventh" };

        public override List<string> QualityAbbreviation { get; }
            = new List<string> { "M7" };

        public override List<string> QualityAbbreviation2 { get; }
            = new List<string> { "Maj. 7" };

        public override string QualityComposition { get; }
            = "5 tons et 1 demi-ton diatonique";

        public override int Semitones { get; } 
            = 11;

        public override IntervalNumber Number { get; } 
            = new IntervalNumberSeventh();

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