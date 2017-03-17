namespace MidiMinuit.Lib.Instruments.GuitarTunings
{
    using Core.Notes;

    public class GuitarString
    {
        public GuitarString(int stringIndex)
        {
            StringIndex = stringIndex;
            Note = null;
            Retune = null;
            Fret = null;
        }

        public GuitarString(int stringIndex, int noteMidi, int retune, int? fret = null)
        {
            StringIndex = stringIndex;
            Note = new Note(noteMidi);
            Retune = retune;
            Fret = fret;
        }

        public int StringIndex { get; }

        public Note Note { get; }

        public int? Retune { get; }

        public int? Fret { get; }
    }
}