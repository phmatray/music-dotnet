using MidiMinuit.Lib.Chords.Core.Degrees.Base;
using MidiMinuit.Lib.Chords.Core.Degrees.Enum;
using MidiMinuit.Lib.Chords.Core.Notes.Base;
using MidiMinuit.Lib.Chords.Core.Notes.Enum;

namespace MidiMinuit.Lib.Chords.Core.Degrees
{
    public class Degree3 : Degree
    {
        protected internal Degree3()
            : base()
        {
        }

        public override DegreeOrder DegreeEnum
            => DegreeOrder.III;

        public override string DiatonicFunction
            => "Mediant";

        public override string CorrespondingModeMajorKey
            => "Phrygian";

        public override string CorrespondingModeMinorKey
            => "Ionian";

        public override string Meaning
            => "Midway between tonic and dominant, (in minor key) root of relative major key";

        public override Note NoteInCMajor
            => new Note(NoteName.E);

        public override Note NoteInCMinor
            => new Note(NoteName.E, NoteAccidental.Flat);
    }
}