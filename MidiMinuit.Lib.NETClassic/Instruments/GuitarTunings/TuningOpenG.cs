namespace MidiMinuit.Lib.Instruments.GuitarTunings
{
    public class TuningOpenG : Tuning
    {
        public TuningOpenG()
            : base("D", "G", "D", "G", "B", "D")
        {
        }

        public override string GetName()
        {
            return "Open G";
        }
    }
}