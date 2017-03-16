namespace MidiMinuit.Lib.Core.Degrees
{
    using Notes;

    public class Degree5 : Degree
    {
        public override DegreeNumberEnum Number
            => DegreeNumberEnum.V;

        public override string DiatonicFunction
            => "Dominant";

        public override string CorrespondingModeMajorKey
            => "Mixolydian";

        public override string CorrespondingModeMinorKey
            => "Phrygian";

        public override string Meaning
            => "2nd in importance to the tonic";

        public override string Function { get; }
            = "dominante";

        public override Note NoteInCMajor
            => new Note(NoteName.G);

        public override Note NoteInCMinor
            => new Note(NoteName.G);
    }
}