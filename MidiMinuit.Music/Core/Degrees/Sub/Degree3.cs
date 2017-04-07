namespace MidiMinuit.Music.Core
{
    public class Degree3 : Degree
    {
        public override DegreeAlias Alias { get; }
            = DegreeAlias.III;

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

        public override Pitch PitchInCMajor { get; }
            = new Pitch(StepNameAlias.E);

        public override Pitch PitchInCMinor { get; }
            = new Pitch(StepNameAlias.E);

        public override string ToString()
            => Alias.ToString();
    }
}