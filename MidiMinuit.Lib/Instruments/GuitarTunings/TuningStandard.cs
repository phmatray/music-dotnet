namespace MidiMinuit.Lib.Instruments.GuitarTunings
{
    public class TuningStandard : GuitarTuning
    {
        public TuningStandard()
            : base("E", "A", "D", "G", "B", "E")
        {
        }

        public override string GetName()
        {
            return "Standard";
        }
    }
}