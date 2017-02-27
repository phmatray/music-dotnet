namespace GuitarChords.Lib.Tunings
{
    public class TuningNashville : Tuning
    {
        public TuningNashville()
            : base("E", "A", "D", "G", "B", "E")
        {
        }

        public override string GetName()
        {
            return "Nashville";
        }
    }
}