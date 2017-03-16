namespace MidiMinuit.Lib.Core.Degrees
{
    using Notes;

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
            => new Note(NoteName.D);

        public override Note NoteInCMinor
            => new Note(NoteName.D);
    }
}