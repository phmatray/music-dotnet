namespace MidiMinuit.Lib.Core.Intervals
{
    using System.Collections.Generic;
    using IntervalModifiers;
    using IntervalNumbers;
    using Notes;

    public class IntervalMajorSecond
        : Interval
    {
        public IntervalMajorSecond(Note lowerNote)
            : base(lowerNote)
        {
        }

        public override IntervalAlias Alias { get; }
            = IntervalAlias.IntervalMajorSecond;

        public override IntervalConsonance HarmonicConsonance { get; }
            = IntervalConsonance.Dissonante;

        public override List<string> QualityName { get; }
            = new List<string> { "Major Second", "Tone", "Whole Tone", "Whole Step" };

        public override List<string> QualityAbbreviation { get; }
            = new List<string> { "M2" };

        public override List<string> QualityAbbreviation2 { get; }
            = new List<string> { "Maj. 2" };

        public override string QualityComposition { get; }
            = "1 ton";

        public override int Semitones { get; }
            = 2;

        public override IntervalNumber Number { get; }
            = new IntervalNumberSecond();

        public override IntervalModifier Modifier { get; }
            = new IntervalModifierMajor();

        public override IntervalSpanning Spanning { get; }
            = IntervalSpanning.Simple;

        public override string ToString()
            => Abbreviation;

        public override Interval Clone()
            => MemberwiseClone() as Interval;
    }
}