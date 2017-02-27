namespace GuitarChords.Lib.Tunings
{
    public class TuningStandard : Tuning
    {
        public TuningStandard()
            : base("E", "A", "D", "G", "B", "E")
        {
        }

        public override string GetName()
        {
            return "Standard";
        }
    }
}