namespace MidiMinuit.Lib.Core.Intervals
{
    using System.Collections.Generic;
    using IntervalModifiers;
    using IntervalNumbers;
    using Notes;

    public class IntervalMajorSixth : Interval
    {
        public IntervalMajorSixth(Note lowerNote)
        {
        }

        public override Note LowerNote { get; }

        public override Note UpperNote { get; }

        public override IntervalAlias Alias { get; }
            = IntervalAlias.IntervalMajorSixth;

        public override IntervalConsonance HarmonicConsonance { get; }
            = IntervalConsonance.Imparfaite;

        public override List<string> QualityName { get; }
            = new List<string>
            {
                "Major Sixth",
                "Septimal Major Sixth",
                "Supermajor Sixth",
                "Major Hexachord",
                "Greater Hexachord",
                "Hexachordon Maius"
            };

        public override List<string> QualityAbbreviation { get; }
            = new List<string> { "M6" };

        public override List<string> QualityAbbreviation2 { get; }
            = new List<string> { "Maj. 6" };

        public override string QualityComposition { get; }
            = "4 tons et 1 demi-ton diatonique";

        public override int Semitones { get; }
            = 9;

        public override IntervalNumber Number { get; }
            = new IntervalNumberSixth();

        public override IntervalModifier Modifier { get; }
            = new IntervalModifierMajor();

        public override IntervalSpanning Spanning { get; }
            = IntervalSpanning.Simple;

        public override string ToString()
            => Abbreviation;

        public override Interval Clone()
            => MemberwiseClone() as Interval;
    }
}