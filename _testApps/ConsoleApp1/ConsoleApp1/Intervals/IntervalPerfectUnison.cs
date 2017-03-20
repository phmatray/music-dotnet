using System;
using ConsoleApp1.IntervalModifiers;
using ConsoleApp1.IntervalQualities;

namespace ConsoleApp1.Intervals
{
    using MidiMinuit.Lib.Core.Notes;

    public class IntervalPerfectUnison
        : IntervalSimple
    {
        public IntervalPerfectUnison(Note lowerNote, Note upperNote)
            : base(lowerNote, upperNote)
        {
        }

        public IntervalPerfectUnison(IntervalQuality quality, Note lowerNote)
            : base(quality, lowerNote)
        {
            throw new NotImplementedException();
        }

        public override IntervalSpanning Spanning { get; }
            = IntervalSpanning.Simple;

        public override IntervalNumber Number { get; }
            = IntervalNumber.Unison;

        public override IntervalModifier Modifier { get; }
            = new IntervalModifierPerfect();

        public override Interval Inverse()
            => new IntervalPerfectUnison(Quality, LowerNote);
    }
}