namespace MidiMinuit.Music.Core.IntervalSteps
{
    public class IntervalStepThird
        : IntervalStep
    {
        public override IntervalStepAlias Alias { get; }
            = IntervalStepAlias.Third;

        public override int Steps { get; }
            = 3;

        public override string Name { get; }
            = "Third";

        public override string Abbreviation { get; }
            = "3rd";

        public override IntervalStep Inverse()
            => new IntervalStepSixth();

        public override string ToString()
            => Name;

        public override IntervalStep Clone()
            => MemberwiseClone() as IntervalStep;
    }
}