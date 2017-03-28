namespace MidiMinuit.Lib.Core.Intervals
{
    using System.Collections.Generic;
    using IntervalModifiers;
    using IntervalNumbers;
    using Notes;

    public class IntervalMajorSeventh
        : Interval
    {
        public IntervalMajorSeventh()
        {
        }

        public IntervalMajorSeventh(Note lowerNote)
            : base(lowerNote)
        {
        }

        public override IntervalAlias Alias { get; }
            = IntervalAlias.IntervalMajorSeventh;

        public override IntervalConsonance HarmonicConsonance { get; }
            = IntervalConsonance.Dissonante;

        public override List<string> Names { get; }
            = new List<string> { "Major Seventh", "Supermajor Seventh" };

        public override List<string> Abbreviations { get; }
            = new List<string> { "M7", "Maj. 7" };

        public override string QualityComposition { get; }
            = "5 tons et 1 demi-ton diatonique";

        public override int Semitones { get; }
            = 11;

        public override IntervalNumber Number { get; }
            = new IntervalNumberSeventh();

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