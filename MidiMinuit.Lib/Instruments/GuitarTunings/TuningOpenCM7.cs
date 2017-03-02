namespace MidiMinuit.Lib.Instruments.GuitarTunings
{
    public class TuningOpenCM7 : Tuning
    {
        public TuningOpenCM7()
            : base("C", "G", "E", "G", "B", "E")
        {
        }

        public override string GetName()
        {
            return "Open CM7";
        }
    }
}