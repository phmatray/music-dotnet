namespace MidiMinuit.Music.Core.Intervals
{
    public partial class Interval
    {
        public static implicit operator IntervalAlias(Interval interval)
            => interval.Alias;

        public static implicit operator Interval(IntervalAlias alias)
            => Create(alias);
    }
}