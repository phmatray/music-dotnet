using System.Collections.Generic;
using ConsoleApp1.IntervalModifiers;
using ConsoleApp1.IntervalNumbers;

namespace ConsoleApp1.IntervalQualities
{
    public class IntervalDiminishedSeventh : Interval
    {
        public override IntervalQuality Quality { get; }
            = IntervalQuality.IntervalDiminishedSeventh;

        public override List<string> QualityName { get; }
            = new List<string> { "Diminished Seventh" };

        public override List<string> QualityAbbreviation { get; }
            = new List<string> { "d7", "°7" };

        public override List<string> QualityAbbreviation2 { get; }
            = new List<string> { "deg. 7", "dim. 7" };

        public override string QualityComposition { get; }
            = "3 tons et 3 demi-tons diatoniques";

        public override int Semitones { get; } 
            = 9;

        public override IntervalNumber Number { get; } 
            = new IntervalNumberSeventh();

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