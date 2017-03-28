namespace MidiMinuit.Lib.Core.Intervals
{
    using System.Collections.Generic;
    using IntervalModifiers;
    using IntervalNumbers;
    using Notes;

    public class IntervalDiminishedThird
        : Interval
    {
        public IntervalDiminishedThird()
        {
        }

        public IntervalDiminishedThird(Note lowerNote)
            : base(lowerNote)
        {
        }

        public override IntervalAlias Alias { get; }
            = IntervalAlias.IntervalDiminishedThird;

        public override IntervalConsonance HarmonicConsonance { get; }
            = IntervalConsonance.Dissonante;

        public override List<string> Names { get; }
            = new List<string> { "Diminished Third" };

        public override List<string> Abbreviations { get; }
            = new List<string> { "d3", "°3", "deg. 3", "dim. 3" };

        public override string QualityComposition { get; }
            = "2 demi-tons diatoniques";

        public override int Semitones { get; }
            = 2;

        public override IntervalNumber Number { get; }
            = new IntervalNumberThird();

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