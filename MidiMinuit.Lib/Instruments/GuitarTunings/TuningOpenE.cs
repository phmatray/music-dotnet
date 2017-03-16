namespace MidiMinuit.Lib.Instruments.GuitarTunings
{
    public class TuningOpenE : GuitarTuning
    {
        public TuningOpenE()
            : base("E", "B", "E", "A♭", "B", "E")
        {
        }

        public override string GetName()
        {
            return "Open E";
        }
    }
}