using System;
using MidiMinuit.Music.Core;

namespace MidiMinuit.Cli
{
    class Program
    {
        static void Main(string[] args)
        {
            var interval = Interval.Create(Pitch.C4, Pitch.G4);

            Pitch pitch = Pitch.G4;
            IntervalPerfectFifth fifth = Interval.PerfectFifth;
            Pitch expected = pitch - fifth;

            var interval1 = new IntervalPerfectFifth(Pitch.C4);
            var interval2 = interval1.MakeDescending();

            Chord chord = Pitch.CSharp4.ToChord(ChordAlias.Major);
            Console.WriteLine(chord.ToString());
            Console.ReadLine();
        }
    }
}