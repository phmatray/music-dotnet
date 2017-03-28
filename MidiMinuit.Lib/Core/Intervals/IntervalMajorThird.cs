namespace MidiMinuit.Lib.Core.Intervals
{
    using System.Collections.Generic;
    using IntervalModifiers;
    using IntervalNumbers;
    using Notes;

    public class IntervalMajorThird
        : Interval
    {
        public IntervalMajorThird()
        {
        }

        public IntervalMajorThird(Note lowerNote)
            : base(lowerNote)
        {
        }

        public override IntervalAlias Alias { get; }
            = IntervalAlias.IntervalMajorThird;

        public override IntervalConsonance HarmonicConsonance { get; }
            = IntervalConsonance.Imparfaite;

        public override List<string> Names { get; }
            = new List<string> { "Major Third" };

        public override List<string> Abbreviations { get; }
            = new List<string> { "M3", "Maj. 3" };

        public override string QualityComposition { get; }
            = "2 tons";

        public override int Semitones { get; }
            = 4;

        public override IntervalNumber Number { get; }
            = new IntervalNumberThird();

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