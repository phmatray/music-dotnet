namespace MidiMinuit.Lib.Core.Intervals
{
    using System.Collections.Generic;
    using IntervalModifiers;
    using IntervalNumbers;
    using Notes;

    public class IntervalPerfectFifth : Interval
    {
        public IntervalPerfectFifth(Note lowerNote)
        {
            var lowerNoteOrder = lowerNote.Name.Order;
            var intervalOrder = Number.Order;

            var upperNoteOrder = LowerNote + intervalOrder;
        }

        public override Note LowerNote { get; }

        public override Note UpperNote { get; }

        public override IntervalAlias Alias { get; }
            = IntervalAlias.IntervalPerfectFifth;

        public override IntervalConsonance HarmonicConsonance { get; }
            = IntervalConsonance.Parfaite;

        public override List<string> QualityName { get; }
            = new List<string> { "Perfect Fifth", "Diapente" };

        public override List<string> QualityAbbreviation { get; }
            = new List<string> { "P5" };

        public override List<string> QualityAbbreviation2 { get; }
            = new List<string> { "Perf. 5" };

        public override string QualityComposition { get; }
            = "3 tons et 1 demi-ton diatonique";

        public override int Semitones { get; }
            = 7;

        public override IntervalNumber Number { get; }
            = new IntervalNumberFifth();

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