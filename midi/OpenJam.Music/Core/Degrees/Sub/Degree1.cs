namespace OpenJam.Music.Core
{
    public class Degree1 : Degree
    {
        public override DegreeAlias Alias { get; }
            = DegreeAlias.I;

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

        public override Pitch PitchInCMajor { get; }
            = new Pitch(StepNameAlias.C);

        public override Pitch PitchInCMinor { get; }
            = new Pitch(StepNameAlias.C);

        public override string ToString()
            => Alias.ToString();
    }
}