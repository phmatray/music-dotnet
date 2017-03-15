namespace MidiMinuit.Lib.Core.Intervals
{
    public static class EnumExtensions
    {
        public static int GetValue(this IntervalQualityEnum intervalQuality)
            => (int)intervalQuality;

        public static int GetValue(this IntervalSpanningEnum intervalSpanning)
            => (int)intervalSpanning;
    }
}