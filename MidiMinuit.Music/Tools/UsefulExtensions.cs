namespace MidiMinuit.Music.Tools
{
    using System.Globalization;

    public static class UsefulExtensions
    {
        public static bool IsNullOrWhiteSpaceOrEmptyParentheses(this string s)
        {
            if (string.IsNullOrWhiteSpace(s))
            {
                return true;
            }

            var result = s
                .Replace(" ", string.Empty)
                .Replace("(", string.Empty)
                .Replace(")", string.Empty)
                .Length == 0;

            return result;
        }

        public static string ToStringInvariant(this double d)
        {
            return d.ToString(CultureInfo.InvariantCulture);
        }

        public static string ToStringInvariant(this long l)
        {
            return l.ToString(CultureInfo.InvariantCulture);
        }

        public static string ToStringInvariant(this int i)
        {
            return i.ToString(CultureInfo.InvariantCulture);
        }

        public static string ToStringInvariant(this byte b)
        {
            return b.ToString(CultureInfo.InvariantCulture);
        }
    }
}