namespace MidiMinuit.Lib.Instruments.GuitarTunings
{
    public class TuningOpenD : Tuning
    {
        public TuningOpenD()
            : base("D", "A", "D", "G♭", "A", "D")
        {
        }

        public override string GetName()
        {
            return "Open D";
        }
    }
}