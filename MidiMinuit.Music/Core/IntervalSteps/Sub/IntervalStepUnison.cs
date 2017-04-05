namespace MidiMinuit.Music.Core
{
    public class IntervalStepUnison
        : IntervalStep
    {
        public override IntervalStepAlias Alias { get; }
            = IntervalStepAlias.Unison;

        public override int Steps { get; }
            = 1;

        public override string Name { get; }
            = "Unison";

        public override string Abbreviation { get; }
            = "unison";
        public override IntervalStep Inverse()
            => new IntervalStepUnison();

        public override string ToString()
            => Name;

        public override IntervalStep Clone()
            => MemberwiseClone() as IntervalStep;
    }
}