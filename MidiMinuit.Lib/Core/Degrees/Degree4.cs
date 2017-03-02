using MidiMinuit.Lib.Core.Notes;

namespace MidiMinuit.Lib.Core.Degrees
{
    public class Degree4 : DegreeBase
    {
        protected internal Degree4()
            : base()
        {
        }

        public override DegreeEnum DegreeEnum
            => Degrees.DegreeEnum.IV;

        public override string DiatonicFunction
            => "Subdominant";

        public override string CorrespondingModeMajorKey
            => "Lydian";

        public override string CorrespondingModeMinorKey
            => "Dorian";

        public override string Meaning
            => "Lower dominant, same interval below tonic as dominant is above tonic";

        public override Note NoteInCMajor
            => new Note(NoteNameEnum.F);

        public override Note NoteInCMinor
            => new Note(NoteNameEnum.F);
    }
}