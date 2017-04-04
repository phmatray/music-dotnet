namespace MidiMinuit.Music.Core.IntervalSteps
{
    public class IntervalStepSecond
        : IntervalStep
    {
        public override IntervalStepAlias Alias { get; }
            = IntervalStepAlias.Second;

        public override int Steps { get; }
            = 2;

        public override string Name { get; }
            = "Second";

        public override string Abbreviation { get; }
            = "2nd";

        public override IntervalStep Inverse()
            => new IntervalStepSeventh();

        public override string ToString()
            => Name;

        public override IntervalStep Clone()
            => MemberwiseClone() as IntervalStep;
    }
}