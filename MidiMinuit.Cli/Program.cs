using System;
using System.Collections.Generic;
using System.Linq;
using MidiMinuit.Music.Core;
using MidiMinuit.Music.Tools;

namespace MidiMinuit.Cli
{
    class Program
    {
        static void Main(string[] args)
        {
            var stepNames = MusicContext.StepNames;
            var stepAccidentals = new List<StepAccidental>()
            {
                StepAccidental.Natural,
                StepAccidental.Sharp,
                StepAccidental.Flat,
                StepAccidental.DoubleSharp,
                StepAccidental.DoubleFlat
            };
            var intervals = MusicContext.IntervalSimples;

            foreach (var stepName in stepNames)
            {
                foreach (var stepAccidental in stepAccidentals)
                {
                    foreach (var interval in intervals)
                    {
                        try
                        {
                            var pitch = new Pitch(stepName, stepAccidental);
                            interval.StartingPitch = pitch;
                            var inverse = interval.InverseOctaveDown();

                            Console.WriteLine($"{interval} ({interval.PitchesDetails}) ==> {inverse} ({inverse.PitchesDetails})");
                        }
                        catch (Exception e)
                        {
                            var pitch = new Pitch(stepName, stepAccidental);
                            interval.StartingPitch = pitch;
                            var inverse = interval.InverseOctaveDown();

                            Console.WriteLine($"{interval} ({interval.PitchesDetails}) ==> {inverse} ({inverse.PitchesDetails})");

                            Console.WriteLine(e);
                            throw;
                        }
                    }
                }
            }



            var pitches = MusicContext.Pitches;


            Chord chord = Pitch.CSharp4.ToChord(ChordAlias.Major);
            Console.WriteLine(chord.ToString());
            Console.ReadLine();
        }
    }
}