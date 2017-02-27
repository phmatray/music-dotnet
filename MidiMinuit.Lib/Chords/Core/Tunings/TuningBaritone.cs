namespace GuitarChords.Lib.Tunings
{
    public class TuningBaritone : Tuning
    {
        public TuningBaritone()
            : base("B", "E", "A", "D", "Gb", "B")
        {
        }

        public override string GetName()
        {
            return "Baritone";
        }
    }
}