namespace MidiMinuit.Lib.Instruments.GuitarTunings
{
    public class TuningOpenGm : Tuning
    {
        public TuningOpenGm()
            : base("D", "G", "D", "G", "B♭", "D")
        {
        }

        public override string GetName()
        {
            return "Open Gm";
        }
    }
}