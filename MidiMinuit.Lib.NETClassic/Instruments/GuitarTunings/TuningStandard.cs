namespace MidiMinuit.Lib.Instruments.GuitarTunings
{
    public class TuningStandard : Tuning
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