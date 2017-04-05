using System;
using MidiMinuit.Music.Core;

namespace MidiMinuit.Cli
{
    class Program
    {
        static void Main(string[] args)
        {
            var pitch = Pitch.CSharp4;
            Console.WriteLine(pitch.ToString());
            Console.ReadLine();
        }
    }
}