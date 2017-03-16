namespace MidiMinuit.Lib.Core.Degrees
{
    using Notes;

    public class Degree8 : Degree
    {
        public override DegreeNumberEnum Number
            => DegreeNumberEnum.VIII;

        public override string DiatonicFunction
            => "Tonic (octave)";

        public override string CorrespondingModeMajorKey
            => "Ionian";

        public override string CorrespondingModeMinorKey
            => "Aeolian";

        public override string Meaning
            => "Tonal center, note of final resolution";

        public override string Function { get; }
            = "octave";

        public override Note NoteInCMajor
            => new Note(NoteName.C);

        public override Note NoteInCMinor
            => new Note(NoteName.C);
    }
}