namespace MidiMinuit.Music.Core
{
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

        public override Pitch PitchInCMajor { get; }
            = new Pitch(StepNameAlias.A);

        public override Pitch PitchInCMinor { get; }
            = new Pitch(StepNameAlias.A);

        public override string ToString()
            => Alias.ToString();
    }
}