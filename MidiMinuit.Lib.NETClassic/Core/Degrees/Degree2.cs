using MidiMinuit.Lib.Core.Notes;

namespace MidiMinuit.Lib.Core.Degrees
{
    public class Degree2 : DegreeBase
    {
        public override DegreeEnum DegreeEnum
            => DegreeEnum.II;

        public override string DiatonicFunction
            => "Supertonic";

        public override string CorrespondingModeMajorKey
            => "Dorian";

        public override string CorrespondingModeMinorKey
            => "Locrian";

        public override string Meaning
            => "One whole step above the tonic";

        public override Note NoteInCMajor
            => new Note(NoteNameEnum.D);

        public override Note NoteInCMinor
            => new Note(NoteNameEnum.D);
    }
}