namespace GuitarChords.Lib.Tunings
{
    public class TuningOpenF : Tuning
    {
        public TuningOpenF()
            : base("F", "A", "C", "F", "C", "F")
        {
        }

        public override string GetName()
        {
            return "Open F";
        }
    }
}