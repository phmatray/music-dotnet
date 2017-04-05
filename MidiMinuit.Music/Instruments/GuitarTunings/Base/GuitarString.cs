using MidiMinuit.Music.Core;

namespace MidiMinuit.Music.Instruments
{
    public class GuitarString
    {
        public GuitarString(int stringIndex)
        {
            StringIndex = stringIndex;
            Pitch = null;
            Retune = null;
            Fret = null;
        }

        public GuitarString(int stringIndex, int noteMidi, int retune, int? fret = null)
        {
            StringIndex = stringIndex;
            Pitch = Pitch.FromMidiPitch(noteMidi, Pitch.MidiPitchTranslationMode.Auto);
            Retune = retune;
            Fret = fret;
        }

        public int StringIndex { get; }

        public Pitch Pitch { get; }

        public int? Retune { get; }

        public int? Fret { get; }
    }
}