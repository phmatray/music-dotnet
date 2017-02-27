namespace GuitarChords.Lib.Tunings
{
    public class TuningTuneDownHalfStep : Tuning
    {
        public TuningTuneDownHalfStep()
            : base("Eb", "Ab", "Db", "Gb", "Bb", "Eb")
        {
        }

        public override string GetName()
        {
            return "Tune down 1/2 step";
        }
    }
}