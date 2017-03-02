using MidiMinuit.Lib.Core.Notes;

namespace MidiMinuit.Lib.Core.Degrees
{
    public class Degree5 : DegreeBase
    {
        public override DegreeEnum DegreeEnum
            => DegreeEnum.V;

        public override string DiatonicFunction
            => "Dominant";

        public override string CorrespondingModeMajorKey
            => "Mixolydian";

        public override string CorrespondingModeMinorKey
            => "Phrygian";

        public override string Meaning
            => "2nd in importance to the tonic";

        public override Note NoteInCMajor
            => new Note(NoteNameEnum.G);

        public override Note NoteInCMinor
            => new Note(NoteNameEnum.G);
    }
}