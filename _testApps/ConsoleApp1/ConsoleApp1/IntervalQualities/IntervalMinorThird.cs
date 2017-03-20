using System.Collections.Generic;
using ConsoleApp1.IntervalModifiers;
using ConsoleApp1.Intervals;

namespace ConsoleApp1.IntervalQualities
{
    public class IntervalMinorThird : Interval
    {
        public override IntervalQuality Quality { get; }
            = IntervalQuality.IntervalMinorThird;

        public override List<string> QualityName { get; }
            = new List<string> { "Minor Third" };

        public override List<string> QualityAbbreviation { get; }
            = new List<string> { "m3" };

        public override List<string> QualityAbbreviation2 { get; }
            = new List<string> { "min. 3" };

        public override string QualityComposition { get; }
            = "1 ton et 1 demi-ton diatonique";

        public override int Semitones { get; } 
            = 3;

        public override IntervalNumber Number { get; } 
            = IntervalNumber.Third;

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