namespace MidiMinuit.Lib.Instruments.GuitarTunings
{
    public class TuningOpenA : Tuning
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