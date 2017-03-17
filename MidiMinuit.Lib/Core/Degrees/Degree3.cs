namespace MidiMinuit.Lib.Core.Degrees
{
    using Notes;

    public class Degree3 : Degree
    {
        public override DegreeNumber Number { get; }
            = DegreeNumber.III;

        public override string DiatonicFunction { get; }
            = "Mediant";

        public override string CorrespondingModeMajorKey { get; }
            = "Phrygian";

        public override string CorrespondingModeMinorKey { get; }
            = "Ionian";

        public override string Meaning { get; }
            = "Midway between tonic and dominant, (in minor key) root of relative major key";

        public override string Function { get; }
            = "médiante";

        public override Note NoteInCMajor { get; }
            = new Note(NoteName.E);

        public override Note NoteInCMinor { get; }
            = new Note(NoteName.E, NoteAccidental.Flat);

        public override string ToString()
            => Number.ToString();

        public override Degree Clone()
            => MemberwiseClone() as Degree;
    }
}