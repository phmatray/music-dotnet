namespace MidiMinuit.Lib.Instruments.GuitarTunings
{
    public class TuningOpenDm : GuitarTuning
    {
        public TuningOpenDm()
            : base("D", "A", "D", "F", "A", "D")
        {
        }

        public override string GetName()
        {
            return "Open Dm";
        }
    }
}