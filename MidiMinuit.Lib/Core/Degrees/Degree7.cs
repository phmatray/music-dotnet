namespace MidiMinuit.Lib.Core.Degrees
{
    using Notes;

    public class Degree7 : Degree
    {
        public override DegreeNumberEnum Number { get; }
            = DegreeNumberEnum.VII;

        public override string DiatonicFunction { get; }
            = "Leading tone(in Major scale) / Subtonic (in Natural Minor Scale)";

        public override string CorrespondingModeMajorKey { get; }
            = "Locrian";

        public override string CorrespondingModeMinorKey { get; }
            = "Mixolydian";

        public override string Meaning { get; }
            = "Melodically strong affinity for and leads to tonic/One half step below tonic in Major scale and whole step in Natural minor.";

        public override string Function { get; }
            = "sensible";

        public override Note NoteInCMajor { get; }
            = new Note(NoteName.B);

        public override Note NoteInCMinor { get; }
            = new Note(NoteName.B, NoteAccidental.Flat);

        public override string ToString()
            => Number.ToString();

        public override Degree Clone()
            => MemberwiseClone() as Degree;
    }
}