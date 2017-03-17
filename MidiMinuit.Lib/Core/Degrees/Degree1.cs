namespace MidiMinuit.Lib.Core.Degrees
{
    using Notes;

    public class Degree1 : Degree
    {
        public override DegreeNumber Number { get; }
            = DegreeNumber.I;

        public override string DiatonicFunction { get; }
            = "Tonic";

        public override string CorrespondingModeMajorKey { get; }
            = "Ionian";

        public override string CorrespondingModeMinorKey { get; }
            = "Aeolian";

        public override string Meaning { get; }
            = "Tonal center, note of final resolution";

        public override string Function { get; }
            = "tonique";

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