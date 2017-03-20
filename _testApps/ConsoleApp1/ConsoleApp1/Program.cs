using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Intervals;
using MidiMinuit.Lib.Core.Notes;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var note1 = new Note(NoteName.E);
            var note2 = new Note(NoteName.F);

            var interval = new Interval(note1, note2);
            Console.WriteLine(interval);

            ////var intervalInverse = interval.InverseRaisingLower();
            ////Console.WriteLine(intervalInverse);




            Console.ReadLine();
        }

        static void TestAddCentsToFrequency()
        {
            var frequency = MusicMathFormulaHelpers.AddCentsToFrequency(440, 100);
            Console.WriteLine(frequency);
        }


        static void TestMath()
        {
            var freq1 = 415d;
            var freq2 = 443d;

            var cents = 1200 * Math.Log(freq2 / freq1, 2);
            Console.WriteLine($"Inverval {cents} cents");

            var ratio = freq2 / freq1;
            Console.WriteLine($"f2/f1 {ratio}");



            for (int pitch = 0; pitch <= 12; pitch++)
            {
                var result = Math.Pow(2, (double)pitch / 12);
                Console.WriteLine(result);
            }
        }
    }
}
