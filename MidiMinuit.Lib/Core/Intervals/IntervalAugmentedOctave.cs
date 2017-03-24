namespace MidiMinuit.Lib.Core.Intervals
{
    using System.Collections.Generic;
    using IntervalModifiers;
    using IntervalNumbers;
    using Notes;

    public class IntervalAugmentedOctave
        : Interval
    {
        public IntervalAugmentedOctave(Note lowerNote)
            : base(lowerNote)
        {
        }

        public override IntervalAlias Alias { get; }
            = IntervalAlias.IntervalAugmentedOctave;

        public override IntervalConsonance HarmonicConsonance { get; }
            = IntervalConsonance.Dissonante;

        public override List<string> QualityName { get; }
            = new List<string> { "Augmented Octave", "Augmented Eighth" };

        public override List<string> QualityAbbreviation { get; }
            = new List<string> { "A8", "+8" };

        public override List<string> QualityAbbreviation2 { get; }
            = new List<string> { "Aug. 8" };

        public override string QualityComposition { get; }
            = "5 tons et 3 demi-tons diatoniques";

        public override int Semitones { get; }
            = 13;

        public override IntervalNumber Number { get; }
            = new IntervalNumberOctave();

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