namespace MidiMinuit.Lib.Core.Intervals
{
    using System.Collections.Generic;
    using IntervalModifiers;
    using IntervalNumbers;
    using Notes;

    public class IntervalAugmentedSeventh : Interval
    {
        public IntervalAugmentedSeventh(Note lowerNote)
        {
        }

        public override Note LowerNote { get; }

        public override Note UpperNote { get; }

        public override IntervalAlias Alias { get; }
            = IntervalAlias.IntervalAugmentedSeventh;

        public override IntervalConsonance HarmonicConsonance { get; }
            = IntervalConsonance.Parfaite;

        public override List<string> QualityName { get; }
            = new List<string> { "Augmented Seventh" };

        public override List<string> QualityAbbreviation { get; }
            = new List<string> { "A7", "+7" };

        public override List<string> QualityAbbreviation2 { get; }
            = new List<string> { "Aug. 7" };

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