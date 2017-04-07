using System;
using MidiMinuit.Music.Core;

namespace MidiMinuit.Cli
{
    class Program
    {
        static void Main(string[] args)
        {
            var interval1 = new IntervalPerfectFifth(Pitch.C4);
            var interval2 = interval1.MakeDescending();

            //Assert.AreEqual(Pitch.C4, interval1.LowerPitch);
            //Assert.AreEqual(Pitch.G4, interval1.UpperPitch);
            //Assert.AreEqual(Pitch.G4, interval2.LowerPitch);
            //Assert.AreEqual(Pitch.C4, interval2.UpperPitch);

            ChordMajor chordMajor = Chord.Major;

            var chord = Pitch.CSharp4.ToChord(ChordAlias.Major);
            Console.WriteLine(chord.ToString());
            Console.ReadLine();
        }
    }
}