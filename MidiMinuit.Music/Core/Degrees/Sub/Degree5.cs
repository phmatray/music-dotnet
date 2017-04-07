namespace MidiMinuit.Music.Core
{
    public class Degree5 : Degree
    {
        public override DegreeAlias Alias { get; }
            = DegreeAlias.V;

        public override string DiatonicFunction { get; }
            = "Dominant";

        public override string CorrespondingModeMajorKey { get; }
            = "Mixolydian";

        public override string CorrespondingModeMinorKey { get; }
            = "Phrygian";

        public override string Meaning { get; }
            = "2nd in importance to the tonic";

        public override string Function { get; }
            = "dominante";

        public override Pitch PitchInCMajor { get; }
            = new Pitch(StepNameAlias.G);

        public override Pitch PitchInCMinor { get; }
            = new Pitch(StepNameAlias.G);

        public override string ToString()
            => Alias.ToString();
    }
}