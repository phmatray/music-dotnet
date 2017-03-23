namespace MidiMinuit.Lib.Core.Intervals
{
    using System.Collections.Generic;
    using IntervalModifiers;
    using IntervalNumbers;
    using Notes;

    public class IntervalAugmentedSecond : Interval
    {
        public IntervalAugmentedSecond(Note lowerNote)
        {
        }

        public override Note LowerNote { get; }

        public override Note UpperNote { get; }

        public override IntervalAlias Alias { get; }
            = IntervalAlias.IntervalAugmentedSecond;

        public override IntervalConsonance HarmonicConsonance { get; }
            = IntervalConsonance.Dissonante;

        public override List<string> QualityName { get; }
            = new List<string> { "Augmented Second" };

        public override List<string> QualityAbbreviation { get; }
            = new List<string> { "A2", "+2" };

        public override List<string> QualityAbbreviation2 { get; }
            = new List<string> { "Aug. 2" };

        public override string QualityComposition { get; }
            = "1 ton et 1 demi-ton chromatique";

        public override int Semitones { get; }
            = 3;

        public override IntervalNumber Number { get; }
            = new IntervalNumberSecond();

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