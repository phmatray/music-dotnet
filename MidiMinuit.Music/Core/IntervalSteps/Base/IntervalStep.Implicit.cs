namespace MidiMinuit.Music.Core
{
    public partial class IntervalStep
    {
        public static implicit operator IntervalStepAlias(IntervalStep step)
            => step.Alias;

        public static implicit operator IntervalStep(IntervalStepAlias alias)
            => Create(alias);
    }
}