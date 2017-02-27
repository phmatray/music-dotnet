namespace GuitarChords.Lib.Tunings
{
    public class TuningOpenD6 : Tuning
    {
        public TuningOpenD6()
            : base("D", "A", "D", "Gb", "B", "D")
        {
        }

        public override string GetName()
        {
            return "Open D6";
        }
    }
}