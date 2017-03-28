namespace MidiMinuit.Lib.Core.Intervals
{
    using System.Collections.Generic;
    using IntervalModifiers;
    using IntervalNumbers;
    using Notes;

    public class IntervalMinorSecond
        : Interval
    {
        public IntervalMinorSecond()
        {
        }

        public IntervalMinorSecond(Note lowerNote)
            : base(lowerNote)
        {
        }

        public override IntervalAlias Alias { get; }
            = IntervalAlias.IntervalMinorSecond;

        public override IntervalConsonance HarmonicConsonance { get; }
            = IntervalConsonance.Dissonante;

        public override List<string> Names { get; }
            = new List<string> { "Minor Second", "Semitone", "Half Tone", "Half Step" };

        public override List<string> Abbreviations { get; }
            = new List<string> { "m2", "min. 2" };

        public override string QualityComposition { get; }
            = "1 demi-ton diatonique";

        public override int Semitones { get; }
            = 1;

        public override IntervalNumber Number { get; }
            = new IntervalNumberSecond();

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