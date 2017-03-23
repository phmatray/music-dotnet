using System.Collections.Generic;
using ConsoleApp1.IntervalModifiers;
using ConsoleApp1.IntervalNumbers;

namespace ConsoleApp1.Intervals
{
    public class IntervalAugmentedUnison : Interval
    {
        public override IntervalAlias Alias { get; }
            = IntervalAlias.IntervalAugmentedUnison;

        public override IntervalConsonance HarmonicConsonance { get; }
            = IntervalConsonance.Dissonante;

        public override List<string> QualityName { get; }
            = new List<string> { "Augmented Unison", "Chromatic Semitone", "Minor Semitone" };

        public override List<string> QualityAbbreviation { get; }
            = new List<string> { "A1", "+1" };

        public override List<string> QualityAbbreviation2 { get; }
            = new List<string> { "Aug. 1" };

        public override string QualityComposition { get; }
            = "NO DATA";

        public override int Semitones { get; } 
            = 1;

        public override IntervalNumber Number { get; } 
            = new IntervalNumberUnison();

        public override IntervalModifier Modifier { get; } 
            = new IntervalModifierAugmented();

        public override IntervalSpanning Spanning { get; } 
            = IntervalSpanning.Simple;

        public override string ToString() 
            => Abbreviation;

        public override Interval Clone() 
            => MemberwiseClone() as Interval;
    }
}