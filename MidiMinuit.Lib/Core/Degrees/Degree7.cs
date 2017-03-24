namespace MidiMinuit.Lib.Core.Degrees
{
    using NoteAccidentals;
    using NoteNames;
    using Notes;

    public class Degree7 : Degree
    {
        public override DegreeAlias Alias { get; }
            = DegreeAlias.VII;

        public override string DiatonicFunction { get; }
            = "Leading tone(in Major scale) / Subtonic (in Natural Minor Scale)";

        public override string CorrespondingModeMajorKey { get; }
            = "Locrian";

        public override string CorrespondingModeMinorKey { get; }
            = "Mixolydian";

        public override string Meaning { get; }
            = "Melodically strong affinity for and leads to tonic/One half step below " +
              "tonic in Major scale and whole step in Natural minor.";

        public override string Function { get; }
            = "sensible";

        public override Note NoteInCMajor { get; }
            = new Note(new NoteNameB());

        public override Note NoteInCMinor { get; }
            = new Note(new NoteNameB(), new NoteAccidentalFlat());

        public override string ToString()
            => Alias.ToString();

        public override Degree Clone()
            => MemberwiseClone() as Degree;
    }
}