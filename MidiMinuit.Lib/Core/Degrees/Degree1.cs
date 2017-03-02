using MidiMinuit.Lib.Core.Notes;

namespace MidiMinuit.Lib.Core.Degrees
{
    public class Degree1 : DegreeBase
    {
        protected internal Degree1()
            : base()
        {
        }

        public override DegreeEnum DegreeEnum
            => DegreeEnum.I;

        public override string DiatonicFunction
            => "Tonic";

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