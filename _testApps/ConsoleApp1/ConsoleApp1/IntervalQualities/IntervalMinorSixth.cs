using System.Collections.Generic;
using ConsoleApp1.IntervalModifiers;
using ConsoleApp1.Intervals;

namespace ConsoleApp1.IntervalQualities
{
    public class IntervalMinorSixth : Interval
    {
        public override IntervalQuality Quality { get; }
            = IntervalQuality.IntervalMinorSixth;

        public override List<string> QualityName { get; }
            = new List<string> { "Minor Sixth", "Minor Hexachord", "Hexachordon Minus", "Lesser Hexachord" };

        public override List<string> QualityAbbreviation { get; }
            = new List<string> { "m6" };

        public override List<string> QualityAbbreviation2 { get; }
            = new List<string> { "min. 6" };

        public override string QualityComposition { get; }
            = "3 tons et 2 demi-tons diatoniques";

        public override int Semitones { get; } 
            = 8;

        public override IntervalNumber Number { get; } 
            = IntervalNumber.Sixth;

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