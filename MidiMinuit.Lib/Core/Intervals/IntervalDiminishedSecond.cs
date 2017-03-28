namespace MidiMinuit.Lib.Core.Intervals
{
    using System.Collections.Generic;
    using IntervalModifiers;
    using IntervalNumbers;
    using Notes;

    public class IntervalDiminishedSecond
        : Interval
    {
        public IntervalDiminishedSecond()
        {
        }

        public IntervalDiminishedSecond(Note lowerNote)
            : base(lowerNote)
        {
        }

        public override IntervalAlias Alias { get; }
            = IntervalAlias.IntervalDiminishedSecond;

        public override IntervalConsonance HarmonicConsonance { get; }
            = IntervalConsonance.Parfaite;

        public override List<string> Names { get; }
            = new List<string> { "Diminished Second" };

        public override List<string> Abbreviations { get; }
            = new List<string> { "d2", "°2", "deg. 2", "dim. 2" };

        public override string QualityComposition { get; }
            = "NO DATA";

        public override int Semitones { get; }
            = 0;

        public override IntervalNumber Number { get; }
            = new IntervalNumberSecond();

        public override IntervalModifier Modifier { get; }
            = new IntervalModifierDiminished();

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