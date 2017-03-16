namespace MidiMinuit.Lib.Core.Degrees
{
    using Notes;

    public class Degree2 : Degree
    {
        public override DegreeNumberEnum Number
            => DegreeNumberEnum.II;

        public override string DiatonicFunction
            => "Supertonic";

        public override string CorrespondingModeMajorKey
            => "Dorian";

        public override string CorrespondingModeMinorKey
            => "Locrian";

        public override string Meaning
            => "One whole step above the tonic";

        public override string Function { get; }
            = "sus-tonique";

        public override Note NoteInCMajor
            => new Note(NoteName.D);

        public override Note NoteInCMinor
            => new Note(NoteName.D);
    }
}