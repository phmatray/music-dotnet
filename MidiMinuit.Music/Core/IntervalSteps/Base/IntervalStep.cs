namespace MidiMinuit.Music.Core
{
    public abstract partial class IntervalStep
    {
        /*
         * See https://en.wikipedia.org/wiki/Interval_(music)
         */

        public abstract IntervalStepAlias Alias { get; }

        public abstract int Steps { get; }

        public abstract string Name { get; }

        public abstract string Abbreviation { get; }

        public abstract IntervalStep Inverse();

        public abstract override string ToString();

        public abstract IntervalStep Clone();
    }
}