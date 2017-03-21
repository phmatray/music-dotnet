using System.Collections.Generic;
using ConsoleApp1.IntervalModifiers;
using ConsoleApp1.IntervalNumbers;

namespace ConsoleApp1.IntervalQualities
{
    public class IntervalDiminishedFifth : Interval
    {
        public override IntervalQuality Quality { get; }
            = IntervalQuality.IntervalDiminishedFifth;

        public override List<string> QualityName { get; }
            = new List<string> { "Diminished Fifth", "Tritone" };

        public override List<string> QualityAbbreviation { get; }
            = new List<string> { "d5", "°5", "TT" };

        public override List<string> QualityAbbreviation2 { get; }
            = new List<string> { "deg. 5", "dim. 5" };

        public override string QualityComposition { get; }
            = "2 tons et 2 demi-tons diatoniques";

        public override int Semitones { get; } 
            = 6;

        public override IntervalNumber Number { get; } 
            = new IntervalNumberFifth();

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