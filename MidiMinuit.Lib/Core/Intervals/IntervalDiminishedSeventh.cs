namespace MidiMinuit.Lib.Core.Intervals
{
    using System.Collections.Generic;
    using IntervalModifiers;
    using IntervalNumbers;
    using Notes;

    public class IntervalDiminishedSeventh
        : Interval
    {
        public IntervalDiminishedSeventh()
        {
        }

        public IntervalDiminishedSeventh(Note lowerNote)
            : base(lowerNote)
        {
        }

        public override IntervalAlias Alias { get; }
            = IntervalAlias.IntervalDiminishedSeventh;

        public override IntervalConsonance HarmonicConsonance { get; }
            = IntervalConsonance.Dissonante;

        public override List<string> Names { get; }
            = new List<string> { "Diminished Seventh" };

        public override List<string> Abbreviations { get; }
            = new List<string> { "d7", "°7", "deg. 7", "dim. 7" };

        public override string QualityComposition { get; }
            = "3 tons et 3 demi-tons diatoniques";

        public override int Semitones { get; }
            = 9;

        public override IntervalNumber Number { get; }
            = new IntervalNumberSeventh();

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