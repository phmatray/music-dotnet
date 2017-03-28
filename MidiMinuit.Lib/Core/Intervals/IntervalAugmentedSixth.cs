namespace MidiMinuit.Lib.Core.Intervals
{
    using System.Collections.Generic;
    using IntervalModifiers;
    using IntervalNumbers;
    using Notes;

    public class IntervalAugmentedSixth
        : Interval
    {
        public IntervalAugmentedSixth()
        {
        }

        public IntervalAugmentedSixth(Note lowerNote)
            : base(lowerNote)
        {
        }

        public override IntervalAlias Alias { get; }
            = IntervalAlias.IntervalAugmentedSixth;

        public override IntervalConsonance HarmonicConsonance { get; }
            = IntervalConsonance.Dissonante;

        public override List<string> Names { get; }
            = new List<string> { "Augmented Sixth" };

        public override List<string> Abbreviations { get; }
            = new List<string> { "A6", "+6", "Aug. 6" };

        public override string QualityComposition { get; }
            = "4 tons, 1 demi-ton diatonique et 1 demi-ton chromatique";

        public override int Semitones { get; }
            = 10;

        public override IntervalNumber Number { get; }
            = new IntervalNumberSixth();

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