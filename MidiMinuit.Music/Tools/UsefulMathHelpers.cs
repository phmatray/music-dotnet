using System;
using System.Globalization;
using System.Linq;

namespace MidiMinuit.Music.Tools
{
    public class UsefulMathHelpers
    {
        /*
         * http://www.sengpielaudio.com/calculator-centsratio.htm
         */

        private static double GetFrequencyRatioF2F1(double freq1, double freq2)
        {
            return freq2 / freq1;
        }

        private static double GetFrequencyRatioF1F2(double freq1, double freq2)
        {
            return freq1 / freq2;
        }

        public static double CentValueDeterminationOfAnInterval(double freq1, double freq2)
        {
            var cents = 1200 * Math.Log(freq2 / freq1, 2);
            return cents;
        }

        public static double ExactValueIn12TET(int pitch)
        {
            var decimalValueIn12TET = Math.Pow(2, (double)pitch / 12);
            return decimalValueIn12TET;
        }

        public static int InvervalClass(int pitch)
        {
            if (pitch < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(pitch));
            }

            var tmp = pitch > 12 ? pitch % 12 : pitch;
            var invervalClass = tmp >= 6 ? Math.Abs(12 - tmp) : tmp;

            return invervalClass;
        }

        public static double BeamAngle(double beamStartX, double beamStartY, double beamEndX, double beamEndY)
        {
            if (beamEndX - beamStartX == 0.0)
            {
                return 0.0;
            }

            return Math.Atan((beamEndY - beamStartY) / (beamEndX - beamStartX));
        }

        public static double CentsToLinear(double cents)
        {
            return Math.Pow(2.0, cents / 1200.0);
        }

        public static double GradToRadians(double angle)
        {
            return angle * 0.0174532925199433;
        }

        public static double Mean(params double[] values)
        {
            if (values == null)
            {
                throw new ArgumentNullException(nameof(values));
            }

            return values.Sum(t => t) / values.Length;
        }

        public static double Median(params double[] values)
        {
            if (values == null)
            {
                throw new ArgumentNullException(nameof(values));
            }

            var num = values.Length;
            switch (num)
            {
                case 0:
                    return 0.0;
                case 1:
                    return values.First();
                default:
                    var array = values.OrderBy(v => v).ToArray();
                    var index = num / 2;
                    return num % 2 != 0
                        ? array[index]
                        : Mean(array[index - 1], array[index]);
            }
        }

        public static string NumberToOrdinal(int number)
        {
            switch (number)
            {
                case 1:
                    return "1st";
                case 2:
                    return "2nd";
                case 3:
                    return "3rd";
            }

            var ordinal = number > 3
                ? $"{number}th"
                : number.ToString();

            return ordinal;
        }

        public static double StemEnd(double firstNoteX, double firstNoteY, double middleNoteX, double lastNoteX, double lastNoteY)
        {
            var num1 = middleNoteX - firstNoteX;
            var num2 = lastNoteX - firstNoteX;
            var num3 = lastNoteY - firstNoteY;

            if (num2 == 0.0)
            {
                return 0.0;
            }

            return num1 * num3 / num2;
        }

        public static double? TryParse(string s)
        {
            return double.TryParse(s, NumberStyles.Number, CultureInfo.InvariantCulture, out double result)
                ? result
                : default(double?);
        }

        public static DateTime? TryParseDateTime(string s)
        {
            return DateTime.TryParse(s, out DateTime result)
                ? result
                : default(DateTime?);
        }

        public static int? TryParseInt(string s)
        {
            return int.TryParse(s, NumberStyles.Number, CultureInfo.InvariantCulture, out int result)
                ? result
                : default(int?);
        }
    }

}