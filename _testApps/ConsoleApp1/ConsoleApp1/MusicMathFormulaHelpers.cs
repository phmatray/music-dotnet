using System;

namespace ConsoleApp1
{
    public class MusicMathFormulaHelpers
    {
        /*
         * http://www.sengpielaudio.com/calculator-centsratio.htm
         */

        public static double CentValueDeterminationOfAnInterval(double frequency1, double frequency2)
        {
            var cents = 1200 * Math.Log(frequency2 / frequency1, 2);
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

        public static double AddCentsToFrequency(double frequency, double cents)
        {
            /* To do this on a (scientific) calculator, all you need to remember is that there are 1200 cents to an octave. The formula is:
             * a*2^(c/1200) = b.
             * 
             * For example, using the information from Dave's table, we can convert 19.56 cents to Hz for a 440.
             * Here a = 440, c = 19.56 and b is what we want to know.
             * 
             * 440*2^(19.56/1200) = 444.9994 Hz.
             */

            return frequency * Math.Pow(2, cents / 1200);
        }

        //public static double ConvertCentsToFrequencyRatio(double cents)
        //{
            
        //}
    }
}