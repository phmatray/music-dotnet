using System.Collections.Generic;
using ConsoleApp1.IntervalModifiers;
using ConsoleApp1.IntervalNumbers;

namespace ConsoleApp1.Intervals
{
    public class IntervalDiminishedOctave : Interval
    {
        public override IntervalAlias Alias { get; }
            = IntervalAlias.IntervalDiminishedOctave;

        public override IntervalConsonance HarmonicConsonance { get; }
            = IntervalConsonance.Dissonante;

        public override List<string> QualityName { get; }
            = new List<string> { "Diminished Octave", "Diminished Eighth" };

        public override List<string> QualityAbbreviation { get; }
            = new List<string> { "d8", "°8" };

        public override List<string> QualityAbbreviation2 { get; }
            = new List<string> { "deg. 8", "dim. 8" };

        public override string QualityComposition { get; }
            = "4 tons et 3 demi-tons diatoniques";

        public override int Semitones { get; } 
            = 11;

        public override IntervalNumber Number { get; } 
            = new IntervalNumberOctave();

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