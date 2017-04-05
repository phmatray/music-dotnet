namespace MidiMinuit.Music.Core
{
    public class IntervalStepEleventh
        : IntervalStep
    {
        public override IntervalStepAlias Alias { get; }
            = IntervalStepAlias.Eleventh;

        public override int Steps { get; }
            = 11;

        public override string Name { get; }
            = "Eleventh";

        public override string Abbreviation { get; }
            = "11th";

        public override IntervalStep Inverse()
            => new IntervalStepSecond();

        public override string ToString()
            => Name;

        public override IntervalStep Clone()
            => MemberwiseClone() as IntervalStep;
    }
}