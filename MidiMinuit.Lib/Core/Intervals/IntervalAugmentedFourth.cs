namespace MidiMinuit.Lib.Core.Intervals
{
    using System.Collections.Generic;
    using IntervalModifiers;
    using IntervalNumbers;
    using Notes;

    public class IntervalAugmentedFourth
        : Interval
    {
        public IntervalAugmentedFourth()
        {
        }

        public IntervalAugmentedFourth(Note lowerNote)
            : base(lowerNote)
        {
        }

        public override IntervalAlias Alias { get; }
            = IntervalAlias.IntervalAugmentedFourth;

        public override IntervalConsonance HarmonicConsonance { get; }
            = IntervalConsonance.Dissonante;

        public override List<string> Names { get; }
            = new List<string> { "Augmented Fourth", "Tritone" };

        public override List<string> Abbreviations { get; }
            = new List<string> { "A4", "+4", "TT", "Aug. 4" };

        public override string QualityComposition { get; }
            = "2 tons, 1 demi-ton diatonique et 1 demi-ton chromatique ou 3 tons(Triton)";

        public override int Semitones { get; }
            = 6;

        public override IntervalNumber Number { get; }
            = new IntervalNumberFourth();

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