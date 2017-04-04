namespace MidiMinuit.Music.Core.IntervalSteps
{
    public class IntervalStepNinth
        : IntervalStep
    {
        public override IntervalStepAlias Alias { get; }
            = IntervalStepAlias.Ninth;

        public override int Steps { get; }
            = 9;

        public override string Name { get; }
            = "Ninth";

        public override string Abbreviation { get; }
            = "9th";

        public override IntervalStep Inverse()
            => new IntervalStepNinth();

        public override string ToString()
            => Name;

        public override IntervalStep Clone()
            => MemberwiseClone() as IntervalStep;
    }
}