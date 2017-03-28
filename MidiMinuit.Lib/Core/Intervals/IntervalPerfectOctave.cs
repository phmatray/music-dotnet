namespace MidiMinuit.Lib.Core.Intervals
{
    using System.Collections.Generic;
    using IntervalModifiers;
    using IntervalNumbers;
    using Notes;

    public class IntervalPerfectOctave
        : Interval
    {
        public IntervalPerfectOctave()
        {
        }

        public IntervalPerfectOctave(Note lowerNote)
            : base(lowerNote)
        {
        }

        public override IntervalAlias Alias { get; }
            = IntervalAlias.IntervalPerfectOctave;

        public override IntervalConsonance HarmonicConsonance { get; }
            = IntervalConsonance.Parfaite;

        public override List<string> Names { get; }
            = new List<string> { "Perfect Octave" };

        public override List<string> Abbreviations { get; }
            = new List<string> { "P8", "Perf. 8" };

        public override string QualityComposition { get; }
            = "5 tons et 2 demi-tons diatoniques";

        public override int Semitones { get; }
            = 12;

        public override IntervalNumber Number { get; }
            = new IntervalNumberOctave();

        public override IntervalModifier Modifier { get; }
            = new IntervalModifierPerfect();

        public override IntervalSpanning Spanning { get; }
            = IntervalSpanning.Simple;

        public override string ToString()
            => Abbreviation;

        public override Interval Clone()
            => MemberwiseClone() as Interval;
    }
}