namespace GuitarChords.Lib.Tunings
{
    public class TuningDroppedE : Tuning
    {
        public TuningDroppedE()
            : base("E", "B", "E", "A", "Db", "Gb")
        {
        }

        public override string GetName()
        {
            return "Dropped E";
        }
    }
}