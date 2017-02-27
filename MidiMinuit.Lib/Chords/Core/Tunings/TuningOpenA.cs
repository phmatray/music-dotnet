namespace GuitarChords.Lib.Tunings
{
    public class TuningOpenA : Tuning
    {
        public TuningOpenA()
            : base("E", "A", "E", "A", "Db", "E")
        {
        }

        public override string GetName()
        {
            return "Open A";
        }
    }
}