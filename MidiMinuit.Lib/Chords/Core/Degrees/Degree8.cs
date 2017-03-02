using MidiMinuit.Lib.Chords.Core.Degrees.Base;
using MidiMinuit.Lib.Chords.Core.Degrees.Enum;
using MidiMinuit.Lib.Chords.Core.Notes.Base;
using MidiMinuit.Lib.Chords.Core.Notes.Enum;

namespace MidiMinuit.Lib.Chords.Core.Degrees
{

    public class Degree8 : Degree
    {
        protected internal Degree8()
            : base()
        {
        }

        public override DegreeOrder DegreeEnum
            => DegreeOrder.VIII;

        public override string DiatonicFunction
            => "Tonic (octave)";

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