namespace MidiMinuit.Lib.Core.Intervals
{
    using System.Collections.Generic;
    using IntervalModifiers;
    using IntervalNumbers;
    using Notes;

    public class IntervalMinorSeventh : Interval
    {
        public IntervalMinorSeventh(Note lowerNote)
        {
        }

        public override Note LowerNote { get; }

        public override Note UpperNote { get; }

        public override IntervalAlias Alias { get; }
            = IntervalAlias.IntervalMinorSeventh;

        public override IntervalConsonance HarmonicConsonance { get; }
            = IntervalConsonance.Dissonante;

        public override List<string> QualityName { get; }
            = new List<string> { "Minor Seventh" };

        public override List<string> QualityAbbreviation { get; }
            = new List<string> { "m7" };

        public override List<string> QualityAbbreviation2 { get; }
            = new List<string> { "min. 7" };

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