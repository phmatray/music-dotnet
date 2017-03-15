namespace MidiMinuit.Lib.Core.Intervals
{
    public abstract class IntervalQualitySimple
        : IntervalQuality
    {
        public abstract IntervalQualitySimple Inverse { get; }
    }
}