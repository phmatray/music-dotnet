namespace MidiMinuit.Lib.Core.Intervals
{
    public static class EnumExtensions
    {
        public static int GetValue(this IntervalThirdEnum intervalThird)
            => (int)intervalThird;

        public static int GetValue(this IntervalFifthEnum intervalFifth)
            => (int)intervalFifth;

        public static int GetValue(this IntervalSeventhEnum intervalSeventh)
            => (int)intervalSeventh;

        public static int GetValue(this IntervalNinthEnum intervalNinth)
            => (int)intervalNinth;

        public static int GetValue(this IntervalEleventhEnum intervalEleventh)
            => (int)intervalEleventh;

        public static int GetValue(this IntervalThirteenthEnum intervalThirteenth)
            => (int)intervalThirteenth;
    }
}