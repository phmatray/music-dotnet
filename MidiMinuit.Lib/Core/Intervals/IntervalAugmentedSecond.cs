namespace MidiMinuit.Lib.Core.Intervals
{
    using System.Collections.Generic;
    using IntervalModifiers;
    using IntervalNumbers;
    using Notes;

    public class IntervalAugmentedSecond
        : Interval
    {
        public IntervalAugmentedSecond()
        {
        }

        public IntervalAugmentedSecond(Note lowerNote)
            : base(lowerNote)
        {
        }

        public override IntervalAlias Alias { get; }
            = IntervalAlias.IntervalAugmentedSecond;

        public override IntervalConsonance HarmonicConsonance { get; }
            = IntervalConsonance.Dissonante;

        public override List<string> Names { get; }
            = new List<string> { "Augmented Second" };

        public override List<string> Abbreviations { get; }
            = new List<string> { "A2", "+2", "Aug. 2" };

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