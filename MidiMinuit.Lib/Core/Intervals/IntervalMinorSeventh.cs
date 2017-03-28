namespace MidiMinuit.Lib.Core.Intervals
{
    using System.Collections.Generic;
    using IntervalModifiers;
    using IntervalNumbers;
    using Notes;

    public class IntervalMinorSeventh
        : Interval
    {
        public IntervalMinorSeventh()
        {
        }

        public IntervalMinorSeventh(Note lowerNote)
            : base(lowerNote)
        {
        }

        public override IntervalAlias Alias { get; }
            = IntervalAlias.IntervalMinorSeventh;

        public override IntervalConsonance HarmonicConsonance { get; }
            = IntervalConsonance.Dissonante;

        public override List<string> Names { get; }
            = new List<string> { "Minor Seventh" };

        public override List<string> Abbreviations { get; }
            = new List<string> { "m7", "min. 7" };

        public override string QualityComposition { get; }
            = "4 tons et 2 demi-tons diatoniques";

        public override int Semitones { get; }
            = 10;

        public override IntervalNumber Number { get; }
            = new IntervalNumberSeventh();

        public override IntervalModifier Modifier { get; }
            = new IntervalModifierMinor();

        public override IntervalSpanning Spanning { get; }
            = IntervalSpanning.Simple;

        public override string ToString()
            => Abbreviation;

        public override Interval Clone()
            => MemberwiseClone() as Interval;
    }
}