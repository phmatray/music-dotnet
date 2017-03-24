namespace MidiMinuit.Lib.Core.IntervalNumbers
{
    public abstract class IntervalNumber
    {
        /*
         * See https://en.wikipedia.org/wiki/Interval_(music)
         */

        public abstract IntervalNumberAlias Alias { get; }

        public abstract int Order { get; }

        public abstract string Name { get; }

        public abstract string Abbreviation { get; }

        public abstract IntervalNumber Inverse();

        public abstract override string ToString();

        public abstract IntervalNumber Clone();
    }
}