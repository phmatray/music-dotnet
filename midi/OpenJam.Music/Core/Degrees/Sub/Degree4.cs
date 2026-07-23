namespace OpenJam.Music.Core
{
    public class Degree4 : Degree
    {
        public override DegreeAlias Alias { get; }
            = DegreeAlias.IV;

        public override string DiatonicFunction { get; }
            = "Subdominant";

        public override string CorrespondingModeMajorKey { get; }
            = "Lydian";

        public override string CorrespondingModeMinorKey { get; }
            = "Dorian";

        public override string Meaning { get; }
            = "Lower dominant, same interval below tonic as dominant is above tonic";

        public override string Function { get; }
            = "sous-dominante";

        public override Pitch PitchInCMajor { get; }
            = new Pitch(StepNameAlias.F);

        public override Pitch PitchInCMinor { get; }
            = new Pitch(StepNameAlias.F);

        public override string ToString()
            => Alias.ToString();
    }
}