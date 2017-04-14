using System;
using MidiMinuit.Music.Core;
using MidiMinuit.Music.Tools;

namespace MidiMinuit.Cli
{
    class Program
    {
        static void Main(string[] args)
        {

            foreach (var p in MusicContext.Pitches)
            {
                foreach (var i in MusicContext.Intervals)
                {
                    Pitch result = p + i;
                }
            }

            var interval = Interval.Create(Pitch.C4, Pitch.G4);

            Pitch pitch = Pitch.G4;
            IntervalPerfectFifth fifth = Interval.PerfectFifth;
            Pitch expected = pitch - fifth;

            Chord chord = Pitch.CSharp4.ToChord(ChordAlias.Major);
            Console.WriteLine(chord.ToString());
            Console.ReadLine();
        }
    }
}