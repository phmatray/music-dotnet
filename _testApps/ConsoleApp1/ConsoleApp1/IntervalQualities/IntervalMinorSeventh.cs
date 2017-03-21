using System.Collections.Generic;
using ConsoleApp1.IntervalModifiers;
using ConsoleApp1.IntervalNumbers;

namespace ConsoleApp1.IntervalQualities
{
    public class IntervalMinorSeventh : Interval
    {
        public override IntervalQuality Quality { get; }
            = IntervalQuality.IntervalMinorSeventh;

        public override List<string> QualityName { get; }
            = new List<string> { "Minor Seventh" };

        public override List<string> QualityAbbreviation { get; }
            = new List<string> { "m7" };

        public override List<string> QualityAbbreviation2 { get; }
            = new List<string> { "min. 7" };

        public override string QualityComposition { get; }
            = "4 tons et 2 demi-tons diatoniques";

        public override int Semitones { get; } 
            = 10;

        public override IntervalNumber Number { get; } 
            = new IntervalNumberSeventh();

        public override IntervalModifier Modifier { get; } 
            = new IntervalModifierMinor();

        public override IntervalSpanning Spanning { get; } 
            = IntervalSpanning.Simple;

        public override string ToString() 
            => Abbreviation;

        public override Interval Clone() 
            => MemberwiseClone() as Interval;
    }
}