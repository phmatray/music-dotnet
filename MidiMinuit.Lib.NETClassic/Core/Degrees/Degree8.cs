using MidiMinuit.Lib.Core.Notes;

namespace MidiMinuit.Lib.Core.Degrees
{

    public class Degree8 : DegreeBase
    {
        public override DegreeEnum DegreeEnum
            => DegreeEnum.VIII;

        public override string DiatonicFunction
            => "Tonic (octave)";

        public override string CorrespondingModeMajorKey
            => "Ionian";

        public override string CorrespondingModeMinorKey
            => "Aeolian";

        public override string Meaning
            => "Tonal center, note of final resolution";

        public override Note NoteInCMajor
            => new Note(NoteNameEnum.C);

        public override Note NoteInCMinor
            => new Note(NoteNameEnum.C);
    }
}