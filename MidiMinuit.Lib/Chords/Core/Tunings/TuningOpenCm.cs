namespace GuitarChords.Lib.Tunings
{
    public class TuningOpenCm : Tuning
    {
        public TuningOpenCm()
            : base("C", "G", "C", "G", "C", "Eb")
        {
        }

        public override string GetName()
        {
            return "Open Cm";
        }
    }
}