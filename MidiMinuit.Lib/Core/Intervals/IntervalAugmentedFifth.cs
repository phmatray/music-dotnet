namespace MidiMinuit.Lib.Core.Intervals
{
    using System.Collections.Generic;
    using IntervalModifiers;
    using IntervalNumbers;
    using Notes;

    public class IntervalAugmentedFifth
        : Interval
    {
        public IntervalAugmentedFifth()
        {
        }

        public IntervalAugmentedFifth(Note lowerNote)
            : base(lowerNote)
        {
        }

        public override IntervalAlias Alias { get; }
            = IntervalAlias.IntervalAugmentedFifth;

        public override IntervalConsonance HarmonicConsonance { get; }
            = IntervalConsonance.Dissonante;

        public override List<string> Names { get; }
            = new List<string> { "Augmented Fifth" };

        public override List<string> Abbreviations { get; }
            = new List<string> { "A5", "+5", "Aug. 5" };

        public override string QualityComposition { get; }
            = "3 tons, 1 demi-ton diatonique et 1 demi-ton chromatique";

        public override int Semitones { get; }
            = 8;

        public override IntervalNumber Number { get; }
            = new IntervalNumberFifth();

        public override IntervalModifier Modifier { get; }
            = new IntervalModifierAugmented();

        public override IntervalSpanning Spanning { get; }
            = IntervalSpanning.Simple;

        public override string WikipediaDescription { get; }
            = "NO DATA";

        public override string ToString()
            => Abbreviation;

        public override Interval Clone()
            => MemberwiseClone() as Interval;
    }
}