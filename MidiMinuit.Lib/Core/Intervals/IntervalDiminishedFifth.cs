namespace MidiMinuit.Lib.Core.Intervals
{
    using System.Collections.Generic;
    using IntervalModifiers;
    using IntervalNumbers;
    using Notes;

    public class IntervalDiminishedFifth : Interval
    {
        public IntervalDiminishedFifth(Note lowerNote)
        {
        }

        public override Note LowerNote { get; }

        public override Note UpperNote { get; }

        public override IntervalAlias Alias { get; }
            = IntervalAlias.IntervalDiminishedFifth;

        public override IntervalConsonance HarmonicConsonance { get; }
            = IntervalConsonance.Dissonante;

        public override List<string> QualityName { get; }
            = new List<string> { "Diminished Fifth", "Tritone" };

        public override List<string> QualityAbbreviation { get; }
            = new List<string> { "d5", "°5", "TT" };

        public override List<string> QualityAbbreviation2 { get; }
            = new List<string> { "deg. 5", "dim. 5" };

        public override string QualityComposition { get; }
            = "2 tons et 2 demi-tons diatoniques";

        public override int Semitones { get; }
            = 6;

        public override IntervalNumber Number { get; }
            = new IntervalNumberFifth();

        public override IntervalModifier Modifier { get; }
            = new IntervalModifierDiminished();

        public override IntervalSpanning Spanning { get; }
            = IntervalSpanning.Simple;

        public override string ToString()
            => Abbreviation;

        public override Interval Clone()
            => MemberwiseClone() as Interval;
    }
}