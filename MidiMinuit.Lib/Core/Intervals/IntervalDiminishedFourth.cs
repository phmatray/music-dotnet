namespace MidiMinuit.Lib.Core.Intervals
{
    using System.Collections.Generic;
    using IntervalModifiers;
    using IntervalNumbers;
    using Notes;

    public class IntervalDiminishedFourth
        : Interval
    {
        public IntervalDiminishedFourth()
        {
        }

        public IntervalDiminishedFourth(Pitch lowerPitch)
            : base(lowerPitch)
        {
        }

        public override IntervalAlias Alias { get; }
            = IntervalAlias.IntervalDiminishedFourth;

        public override IntervalConsonance HarmonicConsonance { get; }
            = IntervalConsonance.Dissonante;

        public override List<string> Names { get; }
            = new List<string> { "Diminished Fourth" };

        public override List<string> Abbreviations { get; }
            = new List<string> { "d4", "°4", "deg. 4", "dim. 4" };

        public override string QualityComposition { get; }
            = "1 ton et 2 demi-tons diatoniques";

        public override int Semitones { get; }
            = 4;

        public override IntervalNumber Number { get; }
            = new IntervalNumberFourth();

        public override IntervalModifier Modifier { get; }
            = new IntervalModifierDiminished();

        public override IntervalSpanning Spanning { get; }
            = IntervalSpanning.Simple;

        public override string WikipediaDescription { get; }
            = @"In classical music from Western culture, a diminished fourth is an interval produced by narrowing a perfect fourth by a chromatic semitone. For example, the interval from C to F is a perfect fourth, five semitones wide, and both the intervals from C♯ to F, and from C to F♭ are diminished fourths, spanning four semitones. Being diminished, it is considered a dissonant interval.";

        public override string ToString()
            => Abbreviation;

        public override Interval Clone()
            => MemberwiseClone() as Interval;
    }
}