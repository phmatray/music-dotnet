namespace MidiMinuit.Music.Core
{
    public partial class IntervalStep
    {
        public static IntervalStepUnison Unison
            => new IntervalStepUnison();

        public static IntervalStepSecond Second
            => new IntervalStepSecond();

        public static IntervalStepThird Third
            => new IntervalStepThird();

        public static IntervalStepFourth Fourth
            => new IntervalStepFourth();

        public static IntervalStepFifth Fifth
            => new IntervalStepFifth();

        public static IntervalStepSixth Sixth
            => new IntervalStepSixth();

        public static IntervalStepSeventh Seventh
            => new IntervalStepSeventh();

        public static IntervalStepOctave Octave
            => new IntervalStepOctave();
    }
}