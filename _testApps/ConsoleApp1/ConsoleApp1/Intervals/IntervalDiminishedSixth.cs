using System.Collections.Generic;
using ConsoleApp1.IntervalModifiers;
using ConsoleApp1.IntervalNumbers;

namespace ConsoleApp1.Intervals
{
    public class IntervalDiminishedSixth : Interval
    {
        public override IntervalQuality Quality { get; }
            = IntervalQuality.IntervalDiminishedSixth;

        public override IntervalConsonance HarmonicConsonance { get; }
            = IntervalConsonance.Dissonante;

        public override List<string> QualityName { get; }
            = new List<string> { "Diminished Sixth" };

        public override List<string> QualityAbbreviation { get; }
            = new List<string> { "d6", "°6" };

        public override List<string> QualityAbbreviation2 { get; }
            = new List<string> { "deg. 6", "dim. 6" };

        public override string QualityComposition { get; }
            = "2 tons et 3 demi-tons diatoniques";

        public override int Semitones { get; } 
            = 7;

        public override IntervalNumber Number { get; } 
            = new IntervalNumberSixth();

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