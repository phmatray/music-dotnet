namespace MidiMinuit.Lib.Core.Intervals
{
    using System.Collections.Generic;
    using IntervalModifiers;
    using IntervalNumbers;
    using Notes;

    public class IntervalPerfectFourth
        : Interval
    {
        public IntervalPerfectFourth()
        {
        }

        public IntervalPerfectFourth(Note lowerNote)
            : base(lowerNote)
        {
        }

        public override IntervalAlias Alias { get; }
            = IntervalAlias.IntervalPerfectFourth;

        public override IntervalConsonance HarmonicConsonance { get; }
            = IntervalConsonance.Mixte;

        public override List<string> Names { get; }
            = new List<string> { "Perfect Fourth", "Diatessaron" };

        public override List<string> Abbreviations { get; }
            = new List<string> { "P4", "Perf. 4" };

        public override string QualityComposition { get; }
            = "2 tons et 1 demi-ton diatonique";

        public override int Semitones { get; }
            = 5;

        public override IntervalNumber Number { get; }
            = new IntervalNumberFourth();

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