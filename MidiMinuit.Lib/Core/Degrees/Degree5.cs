namespace MidiMinuit.Lib.Core.Degrees
{
    using Notes;

    public class Degree5 : Degree
    {
        public override DegreeNumber Number { get; }
            = DegreeNumber.V;

        public override string DiatonicFunction { get; }
            = "Dominant";

        public override string CorrespondingModeMajorKey { get; }
            = "Mixolydian";

        public override string CorrespondingModeMinorKey { get; }
            = "Phrygian";

        public override string Meaning { get; }
            = "2nd in importance to the tonic";

        public override string Function { get; }
            = "dominante";

        public override Note NoteInCMajor { get; }
            = new Note(NoteName.G);

        public override Note NoteInCMinor { get; }
            = new Note(NoteName.G);

        public override string ToString()
            => Number.ToString();

        public override Degree Clone()
            => MemberwiseClone() as Degree;
    }
}