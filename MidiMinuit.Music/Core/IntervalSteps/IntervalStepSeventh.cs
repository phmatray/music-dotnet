namespace MidiMinuit.Music.Core.IntervalNumbers
{
    public class IntervalStepSeventh
        : IntervalStep
    {
        public override IntervalStepAlias Alias { get; }
            = IntervalStepAlias.Seventh;

        public override int Steps { get; }
            = 7;

        public override string Name { get; }
            = "Seventh";

        public override string Abbreviation { get; }
            = "7th";

        public override IntervalStep Inverse()
            => new IntervalStepSecond();

        public override string ToString()
            => Name;

        public override IntervalStep Clone()
            => MemberwiseClone() as IntervalStep;
    }
}