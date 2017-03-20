using System.Collections.Generic;
using ConsoleApp1.IntervalModifiers;
using ConsoleApp1.Intervals;

namespace ConsoleApp1.IntervalQualities
{
    public class IntervalDiminishedThird : Interval
    {
        public override IntervalQuality Quality { get; }
            = IntervalQuality.IntervalDiminishedThird;

        public override List<string> QualityName { get; }
            = new List<string> { "Diminished Third" };

        public override List<string> QualityAbbreviation { get; }
            = new List<string> { "d3", "°3" };

        public override List<string> QualityAbbreviation2 { get; }
            = new List<string> { "deg. 3", "dim. 3" };

        public override string QualityComposition { get; }
            = "2 demi-tons diatoniques";

        public override int Semitones { get; } 
            = 2;

        public override IntervalNumber Number { get; } 
            = IntervalNumber.Third;

        public override IntervalModifier Modifier { get; } 
            = new IntervalModifierDiminished();

        public override IntervalSpanning Spanning { get; } 
            = IntervalSpanning.Simple;

        public override string ToString() 
            => Abbreviation;

        public override Interval Clone() 
            => MemberwiseClone() as Interval;
    }
}