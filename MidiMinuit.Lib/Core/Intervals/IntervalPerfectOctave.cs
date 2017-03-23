namespace MidiMinuit.Lib.Core.Intervals
{
    using System.Collections.Generic;
    using IntervalModifiers;
    using IntervalNumbers;
    using Notes;

    public class IntervalPerfectOctave : Interval
    {
        public IntervalPerfectOctave(Note lowerNote)
        {
        }

        public override Note LowerNote { get; }

        public override Note UpperNote { get; }

        public override IntervalAlias Alias { get; }
            = IntervalAlias.IntervalPerfectOctave;

        public override IntervalConsonance HarmonicConsonance { get; }
            = IntervalConsonance.Parfaite;

        public override List<string> QualityName { get; }
            = new List<string> { "Perfect Octave" };

        public override List<string> QualityAbbreviation { get; }
            = new List<string> { "P8" };

        public override List<string> QualityAbbreviation2 { get; }
            = new List<string> { "Perf. 8" };

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