namespace MidiMinuit.Music.Core
{
    public class IntervalStepFifth
        : IntervalStep
    {
        public override IntervalStepAlias Alias { get; }
            = IntervalStepAlias.Fifth;

        public override int Steps { get; }
            = 5;

        public override string Name { get; }
            = "Fifth";

        public override string Abbreviation { get; }
            = "5th";

        public override IntervalStep Inverse()
            => new IntervalStepFourth();

        public override string ToString()
            => Name;

        public override IntervalStep Clone()
            => MemberwiseClone() as IntervalStep;
    }
}