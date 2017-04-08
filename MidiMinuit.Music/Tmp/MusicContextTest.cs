using System.Linq;
using MidiMinuit.Music.Core;
using MidiMinuit.Music.Instruments;
using MidiMinuit.Music.Tools;

namespace MidiMinuit.Music.Tmp
{
    public class MusicContextTest
    {
        public MusicContextTest()
        {
            var intervals = MusicContext.Intervals.Where(x => x.Semitones == 5).ToList();
            var chordGMajor = MusicContext.Chords.Where(x => x.Fondamental.EndingPitch == Pitch.C4).ToList();
            StepName stepName = MusicContext.StepNames.Single(x => x.Name == "C");
            var guitarTunings = MusicContext.GuitarTunings.Where(x => x.Category == GuitarTuningCategory.Regular);
            var guitarTuning = GuitarTuning.Standard;
        }
    }
}