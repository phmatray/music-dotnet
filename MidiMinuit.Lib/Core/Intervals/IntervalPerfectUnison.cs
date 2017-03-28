namespace MidiMinuit.Lib.Core.Intervals
{
    using System.Collections.Generic;
    using IntervalModifiers;
    using IntervalNumbers;
    using Notes;

    public class IntervalPerfectUnison
        : Interval
    {
        public IntervalPerfectUnison()
        {
        }

        public IntervalPerfectUnison(Note lowerNote)
            : base(lowerNote)
        {
        }

        public override IntervalAlias Alias { get; }
            = IntervalAlias.IntervalPerfectUnison;

        public override IntervalConsonance HarmonicConsonance { get; }
            = IntervalConsonance.Parfaite;

        public override List<string> Names { get; }
            = new List<string> { "Perfect Unison", "Prime", "Perfect Prime" };

        public override List<string> Abbreviations { get; }
            = new List<string> { "P1", "Perf. 1" };

        public override string QualityComposition { get; }
            = "NO DATA";

        public override int Semitones { get; }
            = 0;

        public override IntervalNumber Number { get; }
            = new IntervalNumberUnison();

        public override IntervalModifier Modifier { get; }
            = new IntervalModifierPerfect();

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