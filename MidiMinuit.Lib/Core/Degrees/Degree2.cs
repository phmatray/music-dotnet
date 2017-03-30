namespace MidiMinuit.Lib.Core.Degrees
{
    using NoteNames;
    using Notes;

    public class Degree2 : Degree
    {
        public override DegreeAlias Alias { get; }
            = DegreeAlias.II;

        public override string DiatonicFunction { get; }
            = "Supertonic";

        public override string CorrespondingModeMajorKey { get; }
            = "Dorian";

        public override string CorrespondingModeMinorKey { get; }
            = "Locrian";

        public override string Meaning { get; }
            = "One whole step above the tonic";

        public override string Function { get; }
            = "sus-tonique";

        public override Pitch PitchInCMajor { get; }
            = new Pitch(new NoteNameD());

        public override Pitch PitchInCMinor { get; }
            = new Pitch(new NoteNameD());

        public override string ToString()
            => Alias.ToString();

        public override Degree Clone()
            => MemberwiseClone() as Degree;
    }
}