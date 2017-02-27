namespace GuitarChords.Lib.Tunings
{
    public class TuningOpenE : Tuning
    {
        public TuningOpenE()
            : base("E", "B", "E", "Ab", "B", "E")
        {
        }

        public override string GetName()
        {
            return "Open E";
        }
    }
}