using System;
using ConsoleApp1.Intervals;
using ConsoleApp1.IntervalsOld;
using MidiMinuit.Lib.Core.Notes;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var note1 = new Note(NoteName.C, NoteAccidental.DoubleSharp);
            var note2 = new Note(NoteName.G);
            var interval = new IntervalPerfectFifth();

            var upperNote = IntervalExtensions.GetUpperNote(note1, interval);
            Console.WriteLine(upperNote);


            //var interval = new Interval(note1, note2);
            //Console.WriteLine(interval);

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
