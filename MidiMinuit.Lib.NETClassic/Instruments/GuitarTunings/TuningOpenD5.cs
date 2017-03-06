namespace MidiMinuit.Lib.Instruments.GuitarTunings
{
    public class TuningOpenD5 : Tuning
    {
        public TuningOpenD5()
            : base("D", "A", "D", "D", "A", "D")
        {
        }

        public override string GetName()
        {
            return "Open D5";
        }
    }
}