using System.Collections.Generic;
using System.Linq;
using MidiMinuit.Music.Core.Chords;
using MidiMinuit.Music.Core.Intervals;
using MidiMinuit.Music.Core.Notes;
using MidiMinuit.Music.Instruments.GuitarTunings;

namespace MidiMinuit.Music.Tmp
{
    public class TestMemoryContext
    {
        public TestMemoryContext()
        {
            //Pitch.C4
            //var c4 = MemoryContext.Pitches.C4;
            MemoryContext.Chords.GetByFond(Pitch.C4);
        }
    }

    public static class MemoryContext
    {
        public static List<Chord> Chords { get; set; }

        public static List<GuitarTuning> GuitarTunings { get; set; }

        public static List<Interval> Intervals { get; set; }

        public static Pitch Pitches { get; set; }

        public static List<Chord> GetByFond(this List<Chord> chords, Pitch pitch)
        {
            return chords.Where(x => x.Notes.First() == pitch).ToList();
        }
    }
}