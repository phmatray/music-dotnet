using System.Collections.Generic;
using ConsoleApp1.IntervalModifiers;
using ConsoleApp1.Intervals;

namespace ConsoleApp1.IntervalQualities
{
    public class IntervalAugmentedOctave : Interval
    {
        public override IntervalQuality Quality { get; }
            = IntervalQuality.IntervalAugmentedOctave;

        public override List<string> QualityName { get; }
            = new List<string> { "Augmented Octave", "Augmented Eighth" };

        public override List<string> QualityAbbreviation { get; }
            = new List<string> { "A8", "+8" };

        public override List<string> QualityAbbreviation2 { get; }
            = new List<string> { "Aug. 2" };

        public override string QualityComposition { get; }
            = "5 tons et 3 demi-tons diatoniques";

        public override int Semitones { get; } 
            = 13;

        public override IntervalNumber Number { get; } 
            = IntervalNumber.Octave;

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