namespace MidiMinuit.Lib.Core.Intervals
{
    using System.Collections.Generic;
    using IntervalModifiers;
    using IntervalNumbers;
    using Notes;

    public class IntervalAugmentedThird
        : Interval
    {
        public IntervalAugmentedThird(Note lowerNote)
            : base(lowerNote)
        {
        }

        public override IntervalAlias Alias { get; }
            = IntervalAlias.IntervalAugmentedThird;

        public override IntervalConsonance HarmonicConsonance { get; }
            = IntervalConsonance.Mixte;

        public override List<string> QualityName { get; }
            = new List<string> { "Augmented Third" };

        public override List<string> QualityAbbreviation { get; }
            = new List<string> { "A3", "+3" };

        public override List<string> QualityAbbreviation2 { get; }
            = new List<string> { "Aug. 3" };

        public override string QualityComposition { get; }
            = "2 tons et 1 demi-ton chromatique";

        public override int Semitones { get; }
            = 5;

        public override IntervalNumber Number { get; }
            = new IntervalNumberThird();

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