namespace MidiMinuit.Lib.Instruments.GuitarTunings
{
    public class TuningDroppedC : Tuning
    {
        public TuningDroppedC()
            : base("C", "G", "C", "F", "A", "D")
        {
        }

        public override string GetName()
        {
            return "Dropped C";
        }
    }
}