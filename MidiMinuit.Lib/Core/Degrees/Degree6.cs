namespace MidiMinuit.Lib.Core.Degrees
{
    using Notes;

    public class Degree6 : Degree
    {
        public override DegreeNumberEnum Number
            => DegreeNumberEnum.VI;

        public override string DiatonicFunction
            => "Submediant";

        public override string CorrespondingModeMajorKey
            => "Aeolian";

        public override string CorrespondingModeMinorKey
            => "Lydian";

        public override string Meaning
            => "Lower mediant, midway between tonic and subdominant, (in major key) root of relative minor key";

        public override string Function { get; }
            = "sus-dominante";

        public override Note NoteInCMajor
            => new Note(NoteName.A);

        public override Note NoteInCMinor
            => new Note(NoteName.A, NoteAccidental.Flat);
    }
}