namespace MidiMinuit.Lib.Core.Degrees
{
    using Notes;

    public class Degree4 : Degree
    {
        public override DegreeNumberEnum Number
            => DegreeNumberEnum.IV;

        public override string DiatonicFunction
            => "Subdominant";

        public override string CorrespondingModeMajorKey
            => "Lydian";

        public override string CorrespondingModeMinorKey
            => "Dorian";

        public override string Meaning
            => "Lower dominant, same interval below tonic as dominant is above tonic";

        public override string Function { get; }
            = "sous-dominante";

        public override Note NoteInCMajor
            => new Note(NoteName.F);

        public override Note NoteInCMinor
            => new Note(NoteName.F);
    }
}