namespace MidiMinuit.Lib.Tools
{
    public static class StringExtensions
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
    }
}