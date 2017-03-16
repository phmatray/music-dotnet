namespace MidiMinuit.Lib.Core.Degrees
{
    using Notes;

    public class Degree1 : Degree
    {
        public override DegreeNumberEnum Number
            => DegreeNumberEnum.I;

        public override string DiatonicFunction
            => "Tonic";

        public override string CorrespondingModeMajorKey
            => "Ionian";

        public override string CorrespondingModeMinorKey
            => "Aeolian";

        public override string Meaning
            => "Tonal center, note of final resolution";

        public override string Function { get; }
            = "tonique";

        public override Note NoteInCMajor
            => new Note(NoteName.C);

        public override Note NoteInCMinor
            => new Note(NoteName.C);
    }
}