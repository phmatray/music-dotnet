namespace MidiMinuit.Lib.Core.Intervals
{
    using System.Collections.Generic;
    using IntervalModifiers;
    using IntervalNumbers;
    using Notes;

    public class IntervalAugmentedUnison
        : Interval
    {
        public IntervalAugmentedUnison()
        {
        }

        public IntervalAugmentedUnison(Note lowerNote)
            : base(lowerNote)
        {
        }

        public override IntervalAlias Alias { get; }
            = IntervalAlias.IntervalAugmentedUnison;

        public override IntervalConsonance HarmonicConsonance { get; }
            = IntervalConsonance.Dissonante;

        public override List<string> Names { get; }
            = new List<string> { "Augmented Unison", "Chromatic Semitone", "Minor Semitone" };

        public override List<string> Abbreviations { get; }
            = new List<string> { "A1", "+1", "Aug. 1" };

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