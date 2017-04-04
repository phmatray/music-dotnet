namespace MidiMinuit.Music.Core.IntervalSteps
{
    public partial class IntervalStep
    {
        public static IntervalStep Unison
            => Create(IntervalStepAlias.Unison);

        public static IntervalStep Second
            => Create(IntervalStepAlias.Second);

        public static IntervalStep Third
            => Create(IntervalStepAlias.Third);

        public static IntervalStep Fourth
            => Create(IntervalStepAlias.Fourth);

        public static IntervalStep Fifth
            => Create(IntervalStepAlias.Fifth);

        public static IntervalStep Sixth
            => Create(IntervalStepAlias.Sixth);

        public static IntervalStep Seventh
            => Create(IntervalStepAlias.Seventh);

        public static IntervalStep Octave
            => Create(IntervalStepAlias.Octave);
    }
}