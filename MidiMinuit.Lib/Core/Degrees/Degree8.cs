namespace MidiMinuit.Lib.Core.Degrees
{
    using Notes;

    public class Degree8 : Degree
    {
        public override DegreeNumberEnum Number { get; }
            = DegreeNumberEnum.VIII;

        public override string DiatonicFunction { get; }
            = "Tonic (octave)";

        public override string CorrespondingModeMajorKey { get; }
            = "Ionian";

        public override string CorrespondingModeMinorKey { get; }
            = "Aeolian";

        public override string Meaning { get; }
            = "Tonal center, note of final resolution";

        public override string Function { get; }
            = "octave";

        public override Note NoteInCMajor { get; }
            = new Note(NoteName.C);

        public override Note NoteInCMinor { get; }
            = new Note(NoteName.C);

        public override string ToString()
            => Number.ToString();

        public override Degree Clone()
            => MemberwiseClone() as Degree;
    }
}