namespace MidiMinuit.Lib.Instruments.GuitarTunings
{
    public class TuningOpenA : GuitarTuning
    {
        public TuningOpenA()
            : base("E", "A", "E", "A", "D♭", "E")
        {
        }

        public override string GetName()
        {
            return "Open A";
        }
    }
}