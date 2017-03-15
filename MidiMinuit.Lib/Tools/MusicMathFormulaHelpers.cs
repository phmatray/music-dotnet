using System;

namespace MidiMinuit.Lib.Tools
{
    public class MusicMathFormulaHelpers
    {
        // http://www.sengpielaudio.com/calculator-centsratio.htm

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
            if (pitch <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(pitch));
            }

            var tmp = pitch > 12 ? pitch % 12 : pitch;
            var invervalClass = tmp >= 6 ? Math.Abs(12 - tmp) : tmp;

            return invervalClass;
        }
    }
}