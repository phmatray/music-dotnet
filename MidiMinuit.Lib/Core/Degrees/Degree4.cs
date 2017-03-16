namespace MidiMinuit.Lib.Core.Degrees
{
    using Notes;

    public class Degree4 : Degree
    {
        public override DegreeNumber Number { get; }
            = DegreeNumber.IV;

        public override string DiatonicFunction { get; }
            = "Subdominant";

        public override string CorrespondingModeMajorKey { get; }
            = "Lydian";

        public override string CorrespondingModeMinorKey { get; }
            = "Dorian";

        public override string Meaning { get; }
            = "Lower dominant, same interval below tonic as dominant is above tonic";

        public override string Function { get; }
            = "sous-dominante";

        public override Note NoteInCMajor { get; }
            = new Note(NoteName.F);

        public override Note NoteInCMinor { get; }
            = new Note(NoteName.F);

        public override string ToString()
            => Number.ToString();

        public override Degree Clone()
            => MemberwiseClone() as Degree;
    }
}