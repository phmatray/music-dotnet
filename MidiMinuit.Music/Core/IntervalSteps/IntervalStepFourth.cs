namespace MidiMinuit.Music.Core.IntervalNumbers
{
    public class IntervalStepFourth
        : IntervalStep
    {
        public override IntervalStepAlias Alias { get; }
            = IntervalStepAlias.Fourth;

        public override int Steps { get; }
            = 4;

        public override string Name { get; }
            = "Fourth";

        public override string Abbreviation { get; }
            = "4th";

        public override IntervalStep Inverse()
            => new IntervalStepFifth();

        public override string ToString()
            => Name;

        public override IntervalStep Clone()
            => MemberwiseClone() as IntervalStep;
    }
}