namespace MidiMinuit.Lib.Core.Intervals
{
    using System.Collections.Generic;
    using IntervalModifiers;
    using IntervalNumbers;
    using Notes;

    public class IntervalMajorSecond
        : Interval
    {
        public IntervalMajorSecond()
        {
        }

        public IntervalMajorSecond(Note lowerNote)
            : base(lowerNote)
        {
        }

        public override IntervalAlias Alias { get; }
            = IntervalAlias.IntervalMajorSecond;

        public override IntervalConsonance HarmonicConsonance { get; }
            = IntervalConsonance.Dissonante;

        public override List<string> Names { get; }
            = new List<string> { "Major Second", "Tone", "Whole Tone", "Whole Step" };

        public override List<string> Abbreviations { get; }
            = new List<string> { "M2", "Maj. 2" };

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

        public override string WikipediaDescription { get; }
            = "NO DATA";

        public override string ToString()
            => Abbreviation;

        public override Interval Clone()
            => MemberwiseClone() as Interval;
    }
}