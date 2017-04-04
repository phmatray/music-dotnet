using System.Linq;
using MidiMinuit.Music.Core.Pitches;
using MidiMinuit.Music.Core.StepNames;
using MidiMinuit.Music.Tools;

namespace MidiMinuit.Music.Tmp
{
    public class MusicContextTest
    {
        public MusicContextTest()
        {
            var intervals = MusicContext.Intervals.Where(x => x.Semitones == 5).ToList();
            var chordGMajor = MusicContext.Chords.Where(x => x.Fondamental.UpperPitch == Pitch.C4).ToList();
            StepName stepName = MusicContext.StepNames.Single(x => x.Name == "C");
        }
    }
}