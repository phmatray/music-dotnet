namespace GuitarChords.Lib.Tunings
{
    public class TuningOpenGm : Tuning
    {
        public TuningOpenGm()
            : base("D", "G", "D", "G", "Bb", "D")
        {
        }

        public override string GetName()
        {
            return "Open Gm";
        }
    }
}