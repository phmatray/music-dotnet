namespace MidiMinuit.Lib.Core.Intervals
{
    using System.Collections.Generic;
    using IntervalModifiers;
    using IntervalNumbers;
    using Notes;

    public class IntervalAugmentedSeventh
        : Interval
    {
        public IntervalAugmentedSeventh()
        {
        }

        public IntervalAugmentedSeventh(Note lowerNote)
            : base(lowerNote)
        {
        }

        public override IntervalAlias Alias { get; }
            = IntervalAlias.IntervalAugmentedSeventh;

        public override IntervalConsonance HarmonicConsonance { get; }
            = IntervalConsonance.Parfaite;

        public override List<string> Names { get; }
            = new List<string> { "Augmented Seventh" };

        public override List<string> Abbreviations { get; }
            = new List<string> { "A7", "+7", "Aug. 7" };

        public override string QualityComposition { get; }
            = "Inusitée dans la pratique";

        public override int Semitones { get; }
            = 12;

        public override IntervalNumber Number { get; }
            = new IntervalNumberSeventh();

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