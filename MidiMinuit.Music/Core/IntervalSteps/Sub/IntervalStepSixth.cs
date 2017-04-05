namespace MidiMinuit.Music.Core
{
    public class IntervalStepSixth
        : IntervalStep
    {
        public override IntervalStepAlias Alias { get; }
            = IntervalStepAlias.Sixth;

        public override int Steps { get; }
            = 6;

        public override string Name { get; }
            = "Sixth";

        public override string Abbreviation { get; }
            = "6th";

        public override IntervalStep Inverse()
            => new IntervalStepThird();

        public override string ToString()
            => Name;

        public override IntervalStep Clone()
            => MemberwiseClone() as IntervalStep;
    }
}