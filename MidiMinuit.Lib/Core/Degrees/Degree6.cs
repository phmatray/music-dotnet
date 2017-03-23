namespace MidiMinuit.Lib.Core.Degrees
{
    using Notes;

    public class Degree6 : Degree
    {
        public override DegreeAlias Alias { get; }
            = DegreeAlias.VI;

        public override string DiatonicFunction { get; }
            = "Submediant";

        public override string CorrespondingModeMajorKey { get; }
            = "Aeolian";

        public override string CorrespondingModeMinorKey { get; }
            = "Lydian";

        public override string Meaning { get; }
            = "Lower mediant, midway between tonic and subdominant, (in major key) root of relative minor key";

        public override string Function { get; }
            = "sus-dominante";

        public override Note NoteInCMajor { get; }
            = new Note(NoteName.A);

        public override Note NoteInCMinor { get; }
            = new Note(NoteName.A, NoteAccidental.Flat);

        public override string ToString()
            => Alias.ToString();

        public override Degree Clone()
            => MemberwiseClone() as Degree;
    }
}