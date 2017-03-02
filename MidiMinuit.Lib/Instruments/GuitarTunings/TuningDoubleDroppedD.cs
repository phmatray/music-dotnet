namespace MidiMinuit.Lib.Instruments.GuitarTunings
{
    public class TuningDoubleDroppedD : Tuning
    {
        public TuningDoubleDroppedD()
            : base("D", "A", "D", "G", "B", "D")
        {
        }

        public override string GetName()
        {
            return "Double Dropped D";
        }
    }
}