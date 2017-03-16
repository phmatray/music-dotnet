namespace MidiMinuit.Lib.Instruments.GuitarTunings
{
    public class TuningOpenCm : GuitarTuning
    {
        public TuningOpenCm()
            : base("C", "G", "C", "G", "C", "E♭")
        {
        }

        public override string GetName()
        {
            return "Open Cm";
        }
    }
}