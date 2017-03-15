namespace MidiMinuit.Lib.Core.Degrees
{
    using Notes;

    public class Degree6 : DegreeBase
    {
        public override DegreeEnum DegreeEnum
            => DegreeEnum.VI;

        public override string DiatonicFunction
            => "Submediant";

        public override string CorrespondingModeMajorKey
            => "Aeolian";

        public override string CorrespondingModeMinorKey
            => "Lydian";

        public override string Meaning
            => "Lower mediant, midway between tonic and subdominant, (in major key) root of relative minor key";

        public override Note NoteInCMajor
            => new Note(NoteNameEnum.A);

        public override Note NoteInCMinor
            => new Note(NoteNameEnum.A, NoteAccidentalEnum.Flat);
    }
}