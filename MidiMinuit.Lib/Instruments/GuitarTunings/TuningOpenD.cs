namespace MidiMinuit.Lib.Instruments.GuitarTunings
{
    public class TuningOpenD : GuitarTuning
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