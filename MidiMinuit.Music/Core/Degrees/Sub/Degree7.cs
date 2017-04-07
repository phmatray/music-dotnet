namespace MidiMinuit.Music.Core
{
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

        public override Pitch PitchInCMajor { get; }
            = new Pitch(StepNameAlias.B);

        public override Pitch PitchInCMinor { get; }
            = new Pitch(StepNameAlias.B);

        public override string ToString()
            => Alias.ToString();
    }
}