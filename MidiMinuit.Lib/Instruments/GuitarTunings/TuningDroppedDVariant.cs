namespace MidiMinuit.Lib.Instruments.GuitarTunings
{
    public class TuningDroppedDVariant : Tuning
    {
        public TuningDroppedDVariant()
            : base("D", "A", "D", "G", "A", "E")
        {
        }

        public override string GetName()
        {
            return "Dropped D Variant";
        }
    }
}