// voir https://en.wikipedia.org/wiki/Interval_(music)

namespace ConsoleApp1
{
    public static class EnumExtensions
    {
        public static int GetValue(this IntervalQualityEnum quality)
            => (int)quality;

        public static int GetValue(this IntervalNumberEnum number)
            => (int)number;

        public static string GetAbbreviation(this IntervalQualityEnum quality)
            => ((char)quality.GetValue()).ToString();

        public static string GetAbbreviation(this IntervalNumberEnum number)
            => number.GetValue().ToString();
    }
}


