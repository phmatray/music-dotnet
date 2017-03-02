using MidiMinuit.Lib.Chords.Core.Degrees.Base;
using MidiMinuit.Lib.Chords.Core.Degrees.Enum;
using MidiMinuit.Lib.Chords.Core.Notes.Base;
using MidiMinuit.Lib.Chords.Core.Notes.Enum;

namespace MidiMinuit.Lib.Chords.Core.Degrees
{
    public class Degree1 : Degree
    {
        protected internal Degree1()
            : base()
        {
        }

        public override DegreeOrder DegreeEnum
            => DegreeOrder.I;

        public override string DiatonicFunction
            => "Tonic";

        public override string CorrespondingModeMajorKey
            => "Ionian";

        public override string CorrespondingModeMinorKey
            => "Aeolian";

        public override string Meaning
            => "Tonal center, note of final resolution";

        public override Note NoteInCMajor
            => new Note(NoteName.C);

        public override Note NoteInCMinor
            => new Note(NoteName.C);
    }
}