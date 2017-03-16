namespace MidiMinuit.Lib.Instruments.GuitarTunings
{
    public class TuningDroppedD : GuitarTuning
    {
        public TuningDroppedD()
            : base("D", "A", "D", "G", "B", "E")
        {
        }

        public override string GetName()
        {
            return "Dropped D";
        }
    }
}