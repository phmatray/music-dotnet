using MidiMinuit.Music.Core.Notes;

namespace MidiMinuit.Music.Instruments.GuitarTunings
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
            Pitch = new Pitch(noteMidi);
            Retune = retune;
            Fret = fret;
        }

        public int StringIndex { get; }

        public Pitch Pitch { get; }

        public int? Retune { get; }

        public int? Fret { get; }
    }
}