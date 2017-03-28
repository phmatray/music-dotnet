namespace MidiMinuit.Lib.Core.Intervals
{
    using System.Collections.Generic;
    using IntervalModifiers;
    using IntervalNumbers;
    using Notes;

    public class IntervalDiminishedOctave
        : Interval
    {
        public IntervalDiminishedOctave()
        {
        }

        public IntervalDiminishedOctave(Note lowerNote)
            : base(lowerNote)
        {
        }

        public override IntervalAlias Alias { get; }
            = IntervalAlias.IntervalDiminishedOctave;

        public override IntervalConsonance HarmonicConsonance { get; }
            = IntervalConsonance.Dissonante;

        public override List<string> Names { get; }
            = new List<string> { "Diminished Octave", "Diminished Eighth" };

        public override List<string> Abbreviations { get; }
            = new List<string> { "d8", "°8", "deg. 8", "dim. 8" };

        public override string QualityComposition { get; }
            = "4 tons et 3 demi-tons diatoniques";

        public override int Semitones { get; }
            = 11;

        public override IntervalNumber Number { get; }
            = new IntervalNumberOctave();

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