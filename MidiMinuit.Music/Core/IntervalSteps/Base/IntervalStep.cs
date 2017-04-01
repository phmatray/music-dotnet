namespace MidiMinuit.Music.Core.IntervalNumbers
{
    public abstract class IntervalStep
    {
        /*
         * See https://en.wikipedia.org/wiki/Interval_(music)
         */

        public static implicit operator IntervalStep(IntervalStepAlias alias)
        {
            var repo = new IntervalStepRepository();
            var number = repo.Get(alias);
            return number;
        }

        public static implicit operator IntervalStepAlias(IntervalStep step)
        {
            return step.Alias;
        }

        public abstract IntervalStepAlias Alias { get; }

        public abstract int Steps { get; }

        public abstract string Name { get; }

        public abstract string Abbreviation { get; }

        public abstract IntervalStep Inverse();

        public abstract override string ToString();

        public abstract IntervalStep Clone();
    }
}