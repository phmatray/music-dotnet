namespace MidiMinuit.Lib.Instruments.GuitarTunings
{
    public class TuningOpenC6 : GuitarTuning
    {
        public TuningOpenC6()
            : base("C", "G", "C", "G", "A", "E")
        {
        }

        public override string GetName()
        {
            return "Open C6";
        }
    }
}