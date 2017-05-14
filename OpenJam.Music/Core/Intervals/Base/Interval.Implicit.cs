namespace OpenJam.Music.Core
{
    public partial class Interval
    {
        public static implicit operator IntervalAlias(Interval interval)
            => interval.IntervalAlias;

        public static implicit operator Interval(IntervalAlias alias)
            => Create(alias);
    }
}