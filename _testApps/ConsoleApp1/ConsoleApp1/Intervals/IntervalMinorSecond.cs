using System.Collections.Generic;
using ConsoleApp1.IntervalModifiers;
using ConsoleApp1.IntervalNumbers;

namespace ConsoleApp1.Intervals
{
    public class IntervalMinorSecond : Interval
    {
        public override IntervalAlias Alias { get; }
            = IntervalAlias.IntervalMinorSecond;

        public override IntervalConsonance HarmonicConsonance { get; }
            = IntervalConsonance.Dissonante;

        public override List<string> QualityName { get; }
            = new List<string> { "Minor Second", "Semitone", "Half Tone", "Half Step" };

        public override List<string> QualityAbbreviation { get; }
            = new List<string> { "m2" };

        public override List<string> QualityAbbreviation2 { get; }
            = new List<string> { "min. 2" };

        public override string QualityComposition { get; }
            = "1 demi-ton diatonique";

        public override int Semitones { get; } 
            = 1;

        public override IntervalNumber Number { get; } 
            = new IntervalNumberSecond();

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