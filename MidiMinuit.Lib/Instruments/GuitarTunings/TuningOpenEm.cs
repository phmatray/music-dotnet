namespace MidiMinuit.Lib.Instruments.GuitarTunings
{
    public class TuningOpenEm : GuitarTuning
    {
        public TuningOpenEm()
            : base("E", "B", "E", "G", "B", "E")
        {
        }

        public override string GetName()
        {
            return "Open Em";
        }
    }
}