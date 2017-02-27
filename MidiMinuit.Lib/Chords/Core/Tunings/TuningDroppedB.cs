namespace GuitarChords.Lib.Tunings
{
    public class TuningDroppedB : Tuning
    {
        public TuningDroppedB()
            : base("B", "Gb", "B", "E", "Ab", "Db")
        {
        }

        public override string GetName()
        {
            return "Dropped B";
        }
    }
}