using System.Collections.Generic;
using ConsoleApp1.IntervalModifiers;
using ConsoleApp1.IntervalNumbers;

namespace ConsoleApp1.Intervals
{
    public class IntervalMajorSixth : Interval
    {
        public override IntervalAlias Alias { get; }
            = IntervalAlias.IntervalMajorSixth;

        public override IntervalConsonance HarmonicConsonance { get; }
            = IntervalConsonance.Imparfaite;

        public override List<string> QualityName { get; }
            = new List<string>
            {
                "Major Sixth",
                "Septimal Major Sixth",
                "Supermajor Sixth",
                "Major Hexachord",
                "Greater Hexachord",
                "Hexachordon Maius"
            };

        public override List<string> QualityAbbreviation { get; }
            = new List<string> { "M6" };

        public override List<string> QualityAbbreviation2 { get; }
            = new List<string> { "Maj. 6" };

        public override string QualityComposition { get; }
            = "4 tons et 1 demi-ton diatonique";

        public override int Semitones { get; } 
            = 9;

        public override IntervalNumber Number { get; } 
            = new IntervalNumberSixth();

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